namespace AdventureWorks.Repository.Test.Repository.Purchasing
{
    using AdventureWorks.Repository.Test.Main;
    using EntityClasses.Purchasing;
    using NUnit.Framework;

    [TestFixture]
    [Category("Purchasing")]
    public class VendorRepositoryTest : BaseRepositoryTest<Vendor, VendorRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<Vendor, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Vendor> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void VendorRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void VendorRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void VendorRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void VendorRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void VendorRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}