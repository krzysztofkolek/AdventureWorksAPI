namespace AdventureWorks.Repository.Test.Repository.Person
{
    using EntityClasses.Person;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Person")]
    public class ContactRepositoryTest : BaseRepositoryTest<Contact, ContactRepositoryTest>
    {
        public override string DataFileName()
        {
            throw new System.NotImplementedException();
        }

        public override string DataCategory()
        {
            throw new System.NotImplementedException();
        }

        public override int GetObjectId()
        {
            throw new System.NotImplementedException();
        }

        public override System.Linq.Expressions.Expression<System.Func<Contact, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Contact> input)
        {
            throw new System.NotImplementedException();
        }
    }
}