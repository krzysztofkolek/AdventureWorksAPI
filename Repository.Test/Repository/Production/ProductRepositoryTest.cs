namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class ProductRepositoryTest : BaseRepositoryTest<Product, ProductRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<Product, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Product> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void ProductRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void ProductRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void ProductRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void ProductRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void ProductRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}