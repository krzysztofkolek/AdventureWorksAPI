namespace AdventureWorks.Repository.Test.Repository.Person
{
    using EntityClasses.Person;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Person")]
    public class AddressTypeRepositoryTest : BaseRepositoryTest<AddressType, AddressTypeRepositoryTest>
    {

        public override System.Linq.Expressions.Expression<System.Func<AddressType, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<AddressType> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void AddressTypeRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void AddressTypeRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void AddressTypeRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void AddressTypeRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void AddressTypeRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}