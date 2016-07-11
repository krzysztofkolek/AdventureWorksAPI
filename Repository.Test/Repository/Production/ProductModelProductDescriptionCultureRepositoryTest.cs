namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class ProductModelProductDescriptionCultureRepositoryTest : BaseRepositoryTest<ProductModelProductDescriptionCulture, ProductModelProductDescriptionCultureRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<ProductModelProductDescriptionCulture, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ProductModelProductDescriptionCulture> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void ProductModelProductDescriptionCultureRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void ProductModelProductDescriptionCultureRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void ProductModelProductDescriptionCultureRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void ProductModelProductDescriptionCultureRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void ProductModelProductDescriptionCultureRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}