namespace AdventureWorks.Repository.Test.Repository.Purchasing
{
    using EntityClasses.Purchasing;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Purchasing")]
    public class VendorContactRepositoryTest : BaseRepositoryTest<VendorContact, VendorContactRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<VendorContact, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<VendorContact> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void VendorContactRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void VendorContactRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void VendorContactRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void VendorContactRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void VendorContactRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}