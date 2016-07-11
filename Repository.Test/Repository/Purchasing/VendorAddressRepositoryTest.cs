namespace AdventureWorks.Repository.Test.Repository.Purchasing
{
    using EntityClasses.Purchasing;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Purchasing")]
    public class VendorAddressRepositoryTest : BaseRepositoryTest<VendorAddress, VendorAddressRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<VendorAddress, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<VendorAddress> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void VendorAddressRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void VendorAddressRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void VendorAddressRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void VendorAddressRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void VendorAddressRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}