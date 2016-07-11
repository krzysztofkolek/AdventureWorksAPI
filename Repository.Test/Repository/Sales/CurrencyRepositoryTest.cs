namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class CurrencyRepositoryTest : BaseRepositoryTest<Currency, CurrencyRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<Currency, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Currency> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void CurrencyRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void CurrencyRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void CurrencyRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void CurrencyRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void CurrencyRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}