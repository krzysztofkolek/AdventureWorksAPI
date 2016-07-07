namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class ProductModelIllustrationRepositoryTest : BaseRepositoryTest<ProductModelIllustration, ProductModelIllustrationRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<ProductModelIllustration, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ProductModelIllustration> input)
        {
            throw new System.NotImplementedException();
        }
    }
}