namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class CreditCardRepositoryTest : BaseRepositoryTest<CreditCard, CreditCardRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<CreditCard, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<CreditCard> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void CreditCardRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void CreditCardRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void CreditCardRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void CreditCardRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void CreditCardRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}