namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class ProductInventoryRepositoryTest : BaseRepositoryTest<ProductInventory, ProductInventoryRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<ProductInventory, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ProductInventory> input)
        {
            throw new System.NotImplementedException();
        }
    }
}