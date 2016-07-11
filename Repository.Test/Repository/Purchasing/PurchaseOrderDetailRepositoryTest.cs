namespace AdventureWorks.Repository.Test.Repository.Purchasing
{
    using EntityClasses.Purchasing;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Purchasing")]
    public class PurchaseOrderDetailRepositoryTest : BaseRepositoryTest<PurchaseOrderDetail, PurchaseOrderDetailRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<PurchaseOrderDetail, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<PurchaseOrderDetail> input)
        {
            throw new System.NotImplementedException();
        }

        
        [Test]
        [Order(1)]
        public void PurchaseOrderDetailRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void PurchaseOrderDetailRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void PurchaseOrderDetailRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void PurchaseOrderDetailRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void PurchaseOrderDetailRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}