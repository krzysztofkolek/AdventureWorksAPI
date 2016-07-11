namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class SalesOrderHeaderRepositoryTest : BaseRepositoryTest<SalesOrderHeader, SalesOrderHeaderRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<SalesOrderHeader, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<SalesOrderHeader> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void SalesOrderHeaderRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void SalesOrderHeaderRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void SalesOrderHeaderRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void SalesOrderHeaderRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void SalesOrderHeaderRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}