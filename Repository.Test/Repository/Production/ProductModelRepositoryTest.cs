namespace AdventureWorks.Repository.Test.Repository.Production
{
    using AdventureWorks.EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class ProductModelRepositoryTest : BaseRepositoryTest<ProductModel, ProductModelRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<ProductModel, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ProductModel> input)
        {
            throw new System.NotImplementedException();
        }
    }
}