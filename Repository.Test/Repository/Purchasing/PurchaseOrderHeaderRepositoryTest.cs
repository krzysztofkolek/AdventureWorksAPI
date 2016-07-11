namespace AdventureWorks.Repository.Test.Repository.Purchasing
{
    using EntityClasses.Purchasing;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Purchasing")]
    public class PurchaseOrderHeaderRepositoryTest : BaseRepositoryTest<PurchaseOrderHeader, PurchaseOrderHeaderRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<PurchaseOrderHeader, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<PurchaseOrderHeader> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void PurchaseOrderHeaderRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void PurchaseOrderHeaderRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void PurchaseOrderHeaderRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void PurchaseOrderHeaderRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void PurchaseOrderHeaderRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}