namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class SalesTerritoryRepositoryTest : BaseRepositoryTest<SalesTerritory, SalesTerritoryRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<SalesTerritory, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<SalesTerritory> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void SalesTerritoryRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void SalesTerritoryRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void SalesTerritoryRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void SalesTerritoryRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void SalesTerritoryRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}