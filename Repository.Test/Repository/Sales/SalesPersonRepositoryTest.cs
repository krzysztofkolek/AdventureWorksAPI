namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class SalesPersonRepositoryTest : BaseRepositoryTest<SalesPerson, SalesPersonRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<SalesPerson, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<SalesPerson> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void SalesPersonRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void SalesPersonRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void SalesPersonRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void SalesPersonRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void SalesPersonRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}