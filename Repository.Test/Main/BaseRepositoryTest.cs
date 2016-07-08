namespace AdventureWorks.Repository.Test.Main
{
    using AdventureWorks.Repository.dbo;
    using AdventureWorks.Repository.Main;
    using AdventureWorks.Utils;
    using Autofac;
    using NUnit.Framework;
    using Rhino.Mocks;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="C"></typeparam>
    [TestFixture]
    public abstract class BaseRepositoryTest<T, C>
        where T : class, new()
        where C : class, new()
    {

        protected T TestData;
        protected IReadWriteRepository<T> Repository { get; set; }
        protected C Caller { get; set; }

        protected int SavedObjectId { get; set; }

        public BaseRepositoryTest()
        {
            var test = DataCategory();
            ReadData();
            GetObjectId();
        }

        public virtual TestContext GetTestContext()
        {
            return null;
        }

        public virtual void ReadData()
        {
            String basePath = Path.GetFullPath(Path.Combine(GetTestContext().TestDirectory, @"..\..\TestData\"));
            String dataPath = String.Format("{0}\\{1}", DataCategory(), DataFileName());
            String path = String.Format("{0}{1}", basePath, dataPath);

            var typeItem = typeof(T);
            var xmlmanagerType = typeof(XMLManager<>)
                                 .MakeGenericType(typeItem);
            var instanceOfXMLManager = Activator.CreateInstance(xmlmanagerType);
            MethodInfo deserializeMethodFromXMLManager = xmlmanagerType.GetMethod("Deserialize");
            var deserializedObject = deserializeMethodFromXMLManager.Invoke(instanceOfXMLManager, new object[] { path });

            TestData = deserializedObject as T;
        }
        public virtual String DataFileName()
        {
            return String.Format("{0}.xml", typeof(C).Name.Replace("RepositoryTest", ""));
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

        public abstract Expression<System.Func<T, bool>> SearchForExpresion();
        public abstract void BaseSearchForAsserts(IList<T> input);

        public virtual void BaseGetAllAsserts(IList<T> input)
        {

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


        [SetUp]
        public void Setup()
        {
        }


        protected virtual void BaseSearchFor()
        {
            if (TestData != null)
            {
                // ARRANGE
                var _repository = MockRepository.GenerateMock<T>() as IReadWriteRepository<T>;
                // ACT
                var result = Repository.SearchFor(SearchForExpresion());
                // ASSERT
                BaseSearchForAsserts(result);
            }
        }

        protected virtual void BaseGetAll()
        {
            // ARRANGE            
            // ACT
            var result = Repository.GetAll();
            // ASSERT
            BaseGetAllAsserts(result);
        }

        protected virtual void BaseGetById()
        {
            // ARRANGE            
            // ACT
            var result = Repository.GetById(GetObjectId());
            // ASSERT
            BaseGetByIdAsserts(result);
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
        }

        protected virtual void BaseDelete()
        {
            // ARRANGE            
            // ACT
            Repository.Delete(TestData);
            // ASSERT
            BaseDeleteAsserts(TestData);
        }
    }
}
