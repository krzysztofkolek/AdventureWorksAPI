namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class StoreRepositoryTest : BaseRepositoryTest<Store, StoreRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<Store, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Store> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void StoreRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void StoreRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void StoreRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void StoreRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void StoreRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}