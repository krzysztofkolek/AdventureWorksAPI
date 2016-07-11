namespace AdventureWorks.Repository.Test.Main
{
    using AdventureWorks.Utils;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;

    /// <summary>
    /// Generic repository test
    /// Provides basic functionality for tests that can be overiten or extended. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="C"></typeparam>
    [TestFixture]
    public abstract class BaseRepositoryTest<T, C>
        where T : class, new()
        where C : class, new()
    {

        #region Properties
        protected T TestData;
        protected dynamic Repository { get; set; }
        protected C Caller { get; set; }

        protected int SavedObjectId { get; set; }
        #endregion Properties

        #region Constructor
        public BaseRepositoryTest()
        {
            ReadData();
        }
        #endregion Constructor

        #region Abstract Layer
        public abstract Expression<System.Func<T, bool>> SearchForExpresion();
        public abstract void BaseSearchForAsserts(IList<T> input);
        #endregion Abstract Layer

        #region Virtual Methods
        /// <summary>
        /// Method for TestData manipulation
        /// </summary>
        protected virtual void DataOverload()
        {
        }

        public virtual TestContext GetTestContext()
        {
            return TestContext.CurrentContext;
        }

        public virtual void ReadData()
        {
            String basePath = Path.GetFullPath(Path.Combine(GetTestContext().TestDirectory, @"..\..\TestData\"));
            String dataPath = String.Format("{0}\\{1}", DataCategory(), DataFileName());
            String path = String.Format("{0}{1}", basePath, dataPath);

            if (File.Exists(path))
            {
                var typeItem = typeof(T);
                var domainModelInstance = Activator.CreateInstance(typeItem);
                var modelsFromRepositoryTestMOdels = Assembly.LoadFile(GetTestContext().TestDirectory + "/AdventureWorks.Repository.Test.Model.dll");
                var modelFromAdventurworksRepositoryModels = modelsFromRepositoryTestMOdels.DefinedTypes
                                                                          .Where(item => item.Name.Equals(typeItem.Name))
                                                                          .First();
                var xmlmanagerType = typeof(XMLManager<>)
                                                .MakeGenericType(modelFromAdventurworksRepositoryModels);
                var instanceOfXMLManager = Activator.CreateInstance(xmlmanagerType);
                MethodInfo deserializeMethodFromXMLManager = xmlmanagerType.GetMethod("Deserialize");
                var deserializedObject = deserializeMethodFromXMLManager.Invoke(instanceOfXMLManager, new object[] { path });

                PropertiesFiller filler = new PropertiesFiller();
                var mainDeserializedObject = filler.DeserializeFromXMLModelToDomainModel(deserializedObject, domainModelInstance);

                TestData = domainModelInstance as T;
            }
            else
            {
                TestData = null;
            }
        }

        public virtual String DataFileName()
        {
            return String.Format("{0}.xml", typeof(C).Name.Replace("RepositoryTest", "").ToString());
        }

        public virtual String DataCategory()
        {
            var nameWithNamespace = typeof(C).FullName.Split('.');
            return nameWithNamespace[nameWithNamespace.Length - 2];
        }

        public virtual int GetObjectId()
        {
            var idColumnName = typeof(T).GetProperties().Where(item => item.Name.Contains("Id"))
                                                       .Select(item => item.Name)
                                                       .Where(item => item.Contains(typeof(T).Name))
                                                       .FirstOrDefault();
            object value = TestData.GetType().GetProperty(idColumnName).GetValue(TestData);
            return (int)value;
        }

        public virtual int GetSavedObjectId()
        {
            return SavedObjectId;
        }

        private void NoDataHandling()
        {
            throw new InvalidOperationException();
        }

        public virtual void BaseGetAllAsserts(IList<T> input)
        {
            Assert.IsTrue(input.Count() > 1);
        }

        public virtual void BaseGetByIdAsserts(T input)
        {

        }

        public virtual void BaseInsertAsserts(T input)
        {

        }

        public virtual void BaseDeleteAsserts(T input)
        {

        }

        #endregion Virtual Methods

        #region Concreate Methods
        private void RestoreDatabase()
        {
            String file = String.Format("{0}\\Utils\\AdventureWorks2008.bak", GetTestContext().TestDirectory);
            string sql = "Restore Database AdventureWorks FROM DISK ='" + file + "' WITH REPLACE;";

            SqlConnection con = new SqlConnection(@"Data Source=CYSPC\MSSQL2016;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=False;TrustServerCertificate=False");
            SqlCommand command = new SqlCommand(sql, con);

            con.Open();
            command.ExecuteNonQuery();

            con.Close();
        }
        #endregion Concreate Methods

        #region Test Configuration
        /// <summary>
        /// Functionality before each tests
        /// </summary>
        [SetUp]
        public void Setup()
        {
            Type t = typeof(T);
            var assRepo = Assembly.LoadFile(String.Format("{0}/AdventureWorks.Repository.dll", GetTestContext().TestDirectory));
            var typeRepo = assRepo.GetTypes().Where(item => item.Name.StartsWith(t.Name)).First();
            typeRepo = typeRepo.MakeGenericType(new Type[] { t });
            var repoInstance = Activator.CreateInstance(typeRepo);
            Repository = repoInstance;
        }

        /// <summary>
        /// Functionality before all tests
        /// </summary>
        [TestFixtureSetUp]
        public void SetupBeforeAllTests()
        {
            RestoreDatabase();
        }

        /// <summary>
        /// Functionality after all tests
        /// </summary>
        [TestFixtureTearDown]
        public void TearDownAfterAllTests()
        {
            RestoreDatabase();
        }
        #endregion Test Configuration

        #region Virtual Test Methods
        protected virtual void BaseSearchFor()
        {
            if (TestData != null)
            {
                // ARRANGE                
                // ACT
                var result = Repository.SearchFor(SearchForExpresion());
                // ASSERT
                BaseSearchForAsserts(result);
            }
            else
            {
                NoDataHandling();
            }
        }

        protected virtual void BaseGetAll()
        {
            if (TestData != null)
            {
                // ARRANGE            
                // ACT
                var result = Repository.GetAll();
                // ASSERT
                BaseGetAllAsserts(result);
            }
            else
            {
                NoDataHandling();
            }
        }

        protected virtual void BaseGetById()
        {
            if (TestData != null)
            {
                // ARRANGE            
                // ACT
                var result = Repository.GetById(GetObjectId());
                // ASSERT
                BaseGetByIdAsserts(result);
            }
            else
            {
                NoDataHandling();
            }
        }

        protected virtual void BaseInsert()
        {
            if (TestData != null)
            {
                // ARRANGE            
                // ACT
                Repository.Insert(TestData);
                var result = Repository.GetById(GetObjectId());
                // ASSERT
                BaseInsertAsserts(result);
            }
            else
            {
                NoDataHandling();
            }
        }

        protected virtual void BaseDelete()
        {
            if (TestData != null)
            {
                // ARRANGE            
                // ACT
                Repository.Delete(TestData);
                // ASSERT
                BaseDeleteAsserts(TestData);
            }
            else
            {
                NoDataHandling();
            }
        }
        #endregion Virtual Test Methods
    }
}
