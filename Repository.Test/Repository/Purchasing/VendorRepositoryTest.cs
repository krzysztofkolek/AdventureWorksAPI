namespace AdventureWorks.Repository.Test.Repository.Purchasing
{
    using AdventureWorks.Repository.Main;
    using AdventureWorks.Repository.Test.Main;
    using EntityClasses.Purchasing;
    using NUnit.Framework;

    [TestFixture]
    [Category("Purchasing")]
    public class VendorRepositoryTest : BaseRepositoryTest<Vendor, VendorRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<Vendor, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Vendor> input)
        {
            throw new System.NotImplementedException();
        }
    }
}