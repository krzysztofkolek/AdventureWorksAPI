namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class ProductListPriceHistoryRepositoryTest : BaseRepositoryTest<ProductListPriceHistory, ProductListPriceHistoryRepositoryTest>
    {

        public override System.Linq.Expressions.Expression<System.Func<ProductListPriceHistory, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ProductListPriceHistory> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void ProductListPriceHistoryRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void ProductListPriceHistoryRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void ProductListPriceHistoryRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void ProductListPriceHistoryRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void ProductListPriceHistoryRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}