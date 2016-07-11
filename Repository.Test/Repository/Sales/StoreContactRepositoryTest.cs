namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class StoreContactRepositoryTest : BaseRepositoryTest<StoreContact, StoreContactRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<StoreContact, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<StoreContact> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void StoreContactRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void StoreContactRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void StoreContactRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void StoreContactRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void StoreContactRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}