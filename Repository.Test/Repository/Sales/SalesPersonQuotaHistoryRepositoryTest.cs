namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class SalesPersonQuotaHistoryRepositoryTest : BaseRepositoryTest<SalesPersonQuotaHistory, SalesPersonQuotaHistoryRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<SalesPersonQuotaHistory, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<SalesPersonQuotaHistory> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void SalesPersonQuotaHistoryRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void SalesPersonQuotaHistoryRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void SalesPersonQuotaHistoryRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void SalesPersonQuotaHistoryRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void SalesPersonQuotaHistoryRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}