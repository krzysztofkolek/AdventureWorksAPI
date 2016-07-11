namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class CustomerAddressRepositoryTest : BaseRepositoryTest<CustomerAddress, CustomerAddressRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<CustomerAddress, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<CustomerAddress> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void CustomerAddressRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void CustomerAddressRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void CustomerAddressRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void CustomerAddressRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void CustomerAddressRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}