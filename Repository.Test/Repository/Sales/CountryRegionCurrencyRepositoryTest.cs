namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class CountryRegionCurrencyRepositoryTest : BaseRepositoryTest<CountryRegionCurrency, CountryRegionCurrencyRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<CountryRegionCurrency, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<CountryRegionCurrency> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void CountryRegionCurrencyRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void CountryRegionCurrencyRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void CountryRegionCurrencyRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void CountryRegionCurrencyRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void CountryRegionCurrencyRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}