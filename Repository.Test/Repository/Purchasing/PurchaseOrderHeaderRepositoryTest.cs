namespace AdventureWorks.Repository.Test.Repository.Purchasing
{
    using EntityClasses.Purchasing;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Purchasing")]
    public class PurchaseOrderHeaderRepositoryTest : BaseRepositoryTest<PurchaseOrderHeader, PurchaseOrderHeaderRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<PurchaseOrderHeader, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<PurchaseOrderHeader> input)
        {
            throw new System.NotImplementedException();
        }
    }
}