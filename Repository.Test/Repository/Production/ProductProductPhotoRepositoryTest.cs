namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class ProductProductPhotoRepositoryTest : BaseRepositoryTest<ProductProductPhoto, ProductProductPhotoRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<ProductProductPhoto, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ProductProductPhoto> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void ProductProductPhotoRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void ProductProductPhotoRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void ProductProductPhotoRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void ProductProductPhotoRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void ProductProductPhotoRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}