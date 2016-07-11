namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class SpecialOfferRepositoryTest : BaseRepositoryTest<SpecialOffer, SpecialOfferRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<SpecialOffer, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<SpecialOffer> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void SpecialOfferRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void SpecialOfferRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void SpecialOfferRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void SpecialOfferRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void SpecialOfferRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}