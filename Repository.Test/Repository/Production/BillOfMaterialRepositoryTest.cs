namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class BillOfMaterialRepositoryTest : BaseRepositoryTest<BillOfMaterial, BillOfMaterialRepositoryTest>
    {

        public override System.Linq.Expressions.Expression<System.Func<BillOfMaterial, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<BillOfMaterial> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void BillOfMaterialRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void BillOfMaterialRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void BillOfMaterialRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void BillOfMaterialRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void BillOfMaterialRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}