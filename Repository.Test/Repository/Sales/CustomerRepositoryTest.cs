namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class CustomerRepositoryTest : BaseRepositoryTest<Customer, CustomerRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<Customer, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Customer> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void CustomerRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void CustomerRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void CustomerRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void CustomerRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void CustomerRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}