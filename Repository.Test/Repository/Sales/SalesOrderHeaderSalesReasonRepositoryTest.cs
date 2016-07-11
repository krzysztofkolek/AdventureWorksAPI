namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class SalesOrderHeaderSalesReasonRepositoryTest : BaseRepositoryTest<SalesOrderHeaderSalesReason, SalesOrderHeaderSalesReasonRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<SalesOrderHeaderSalesReason, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<SalesOrderHeaderSalesReason> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void SalesOrderHeaderSalesReasonRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void SalesOrderHeaderSalesReasonRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void SalesOrderHeaderSalesReasonRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void SalesOrderHeaderSalesReasonRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void SalesOrderHeaderSalesReasonRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}