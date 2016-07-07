namespace AdventureWorks.Repository.Test.Repository.Person
{
    using EntityClasses.Person;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Person")]
    public class ContactTypeRepositoryTest : BaseRepositoryTest<ContactType, ContactTypeRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<ContactType, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ContactType> input)
        {
            throw new System.NotImplementedException();
        }
    }
}