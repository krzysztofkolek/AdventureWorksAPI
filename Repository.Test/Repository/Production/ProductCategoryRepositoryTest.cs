namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class ProductCategoryRepositoryTest : BaseRepositoryTest<ProductCategory, ProductCategoryRepositoryTest>
    {

        public override System.Linq.Expressions.Expression<System.Func<ProductCategory, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ProductCategory> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void ProductCategoryRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void ProductCategoryRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void ProductCategoryRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void ProductCategoryRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void ProductCategoryRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}