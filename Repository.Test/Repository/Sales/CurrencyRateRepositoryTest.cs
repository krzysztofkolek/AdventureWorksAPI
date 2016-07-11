namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class CurrencyRateRepositoryTest : BaseRepositoryTest<CurrencyRate, CurrencyRateRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<CurrencyRate, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<CurrencyRate> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void CurrencyRateRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void CurrencyRateRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void CurrencyRateRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void CurrencyRateRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void CurrencyRateRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}