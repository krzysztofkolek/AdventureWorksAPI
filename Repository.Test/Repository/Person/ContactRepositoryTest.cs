namespace AdventureWorks.Repository.Test.Repository.Person
{
    using EntityClasses.Person;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Person")]
    public class ContactRepositoryTest : BaseRepositoryTest<Contact, ContactRepositoryTest>
    {

        public override System.Linq.Expressions.Expression<System.Func<Contact, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Contact> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void ContactRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void ContactRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void ContactRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void ContactRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void ContactRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}