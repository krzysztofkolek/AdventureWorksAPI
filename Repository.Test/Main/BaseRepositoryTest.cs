namespace AdventureWorks.Repository.Test.Main
{
    using AdventureWorks.EntityClasses.dbo;
    using AdventureWorks.Repository.dbo;
    using AdventureWorks.Repository.Main;
    using Autofac;
    using NUnit.Framework;
    using Rhino.Mocks;
    using System;
    using System.Collections.Generic;
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


        public BaseRepositoryTest()
        {
            #region
            var builder = new ContainerBuilder();
            //builder.RegisterType<AwbuildVersionRepository<AwbuildVersion>>().As<IReadWriteRepository<T>>();
            builder.RegisterGeneric(typeof(AwbuildVersionRepository<>))
                .As(typeof(IReadWriteRepository<>))
                .SingleInstance();
            var container = builder.Build();



            #endregion
        }

        public virtual void ReadData()
        {
            var assemblyTypes = Assembly.GetExecutingAssembly().DefinedTypes.GetEnumerator();
            while (assemblyTypes.MoveNext())
            {
                var type = assemblyTypes.Current;
                if (type.FullName.Contains("CsvMap"))
                {
                    ////69 method = {CsvHelper.Configuration.CsvClassMap RegisterClassMap(System.Type)}
                    //int genericMethodPlaceInTheMethodsList = 69;
                    //MethodInfo method = csvReader.Configuration
                    //                             .GetType()
                    //                             .GetMethods()[genericMethodPlaceInTheMethodsList];
                    //method.Invoke(csvReader.Configuration, new object[] { type });
                }
            }
        }
        public abstract String DataFileName();
        public abstract String DataCategory();
        public abstract int GetObjectId();

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
            // ARRANGE
            var _repository = MockRepository.GenerateMock<T>() as IReadWriteRepository<T>;
            // ACT
            var result = Repository.SearchFor(SearchForExpresion());
            // ASSERT
            BaseSearchForAsserts(result);
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
            // ARRANGE            
            // ACT
            Repository.Insert(TestData);
            var result = Repository.GetById(GetObjectId());
            // ASSERT
            BaseInsertAsserts(result);
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
