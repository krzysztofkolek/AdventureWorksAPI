namespace AdventureWorks.Repository.Test.Repository.Person
{
    using EntityClasses.Person;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Person")]
    public class ContactTypeRepositoryTest : BaseRepositoryTest<ContactType, ContactTypeRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<ContactType, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ContactType> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void ContactTypeRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void ContactTypeRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void ContactTypeRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void ContactTypeRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void ContactTypeRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}