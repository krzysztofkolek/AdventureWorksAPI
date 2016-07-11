namespace AdventureWorks.Repository.Test.Repository.Person
{
    using EntityClasses.Person;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Person")]
    public class AddressRepositoryTest : BaseRepositoryTest<Address, AddressRepositoryTest>
    {

        public override System.Linq.Expressions.Expression<System.Func<Address, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Address> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void AddressRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void AddressRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void AddressRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void AddressRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void AddressRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}