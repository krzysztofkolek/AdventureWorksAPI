namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class SpecialOfferProductRepositoryTest : BaseRepositoryTest<SpecialOfferProduct, SpecialOfferProductRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<SpecialOfferProduct, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<SpecialOfferProduct> input)
        {
            throw new System.NotImplementedException();
        }


        [Test]
        [Order(1)]
        public void SpecialOfferProductRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void SpecialOfferProductRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void SpecialOfferProductRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void SpecialOfferProductRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void SpecialOfferProductRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}