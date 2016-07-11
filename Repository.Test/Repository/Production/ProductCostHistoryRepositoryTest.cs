namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class ProductCostHistoryRepositoryTest : BaseRepositoryTest<ProductCostHistory, ProductCostHistoryRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<ProductCostHistory, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ProductCostHistory> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void ProductCostHistoryRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void ProductCostHistoryRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void ProductCostHistoryRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void ProductCostHistoryRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void ProductCostHistoryRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}