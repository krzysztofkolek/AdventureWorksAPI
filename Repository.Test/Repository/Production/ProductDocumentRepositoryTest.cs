namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class ProductDocumentRepositoryTest : BaseRepositoryTest<ProductDocument, ProductDocumentRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<ProductDocument, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ProductDocument> input)
        {
            throw new System.NotImplementedException();
        }
    }
}