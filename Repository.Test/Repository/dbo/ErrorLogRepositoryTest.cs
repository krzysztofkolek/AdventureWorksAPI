namespace AdventureWorks.Repository.Test.Repository.dbo
{
    using AdventureWorks.EntityClasses.dbo;
    using Main;
    using NUnit.Framework;


    [TestFixture]
    public class ErrorLogRepositoryTest : BaseRepositoryTest<ErrorLog, ErrorLogRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<ErrorLog, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ErrorLog> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void ErrorLogRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void ErrorLogRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void ErrorLogRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void ErrorLogRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void ErrorLogRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}