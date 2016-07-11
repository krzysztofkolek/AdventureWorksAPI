namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class ContactCreditCardRepositoryTest : BaseRepositoryTest<ContactCreditCard, ContactCreditCardRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<ContactCreditCard, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ContactCreditCard> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void ContactCreditCardRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void ContactCreditCardRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void ContactCreditCardRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void ContactCreditCardRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void ContactCreditCardRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}