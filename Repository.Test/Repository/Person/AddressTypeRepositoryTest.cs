namespace AdventureWorks.Repository.Test.Repository.Person
{
    using EntityClasses.Person;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Person")]
    public class AddressTypeRepositoryTest : BaseRepositoryTest<AddressType, AddressTypeRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<AddressType, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<AddressType> input)
        {
            throw new System.NotImplementedException();
        }
    }
}