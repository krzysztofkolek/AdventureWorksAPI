namespace AdventureWorks.Repository.Test.Repository.Purchasing
{
    using EntityClasses.Purchasing;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Purchasing")]
    public class PurchaseOrderDetailRepositoryTest : BaseRepositoryTest<PurchaseOrderDetail, PurchaseOrderDetailRepositoryTest>
    {
        public override string DataFileName()
        {
            throw new System.NotImplementedException();
        }

        public override string DataCategory()
        {
            throw new System.NotImplementedException();
        }

        public override int GetObjectId()
        {
            throw new System.NotImplementedException();
        }

        public override System.Linq.Expressions.Expression<System.Func<PurchaseOrderDetail, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<PurchaseOrderDetail> input)
        {
            throw new System.NotImplementedException();
        }
    }
}