namespace AdventureWorks.Repository.Test.Repository.Purchasing
{
    using EntityClasses.Purchasing;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Purchasing")]
    public class ShipMethodRepositoryTest : BaseRepositoryTest<ShipMethod, ShipMethodRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<ShipMethod, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ShipMethod> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void ShipMethodRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void ShipMethodRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void ShipMethodRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void ShipMethodRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void ShipMethodRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}