namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class ShoppingCartItemRepositoryTest : BaseRepositoryTest<ShoppingCartItem, ShoppingCartItemRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<ShoppingCartItem, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ShoppingCartItem> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void ShoppingCartItemRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void ShoppingCartItemRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void ShoppingCartItemRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void ShoppingCartItemRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void ShoppingCartItemRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}