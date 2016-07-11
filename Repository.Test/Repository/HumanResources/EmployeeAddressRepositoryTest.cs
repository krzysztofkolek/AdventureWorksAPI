namespace AdventureWorks.Repository.Test.Repository.HumanResources
{
    using EntityClasses.HumanResources;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("HumanResources")]
    public class EmployeeAddressRepositoryTest : BaseRepositoryTest<EmployeeAddress, EmployeeAddressRepositoryTest>
    {

        public override System.Linq.Expressions.Expression<System.Func<EmployeeAddress, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<EmployeeAddress> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void EmployeeAddressRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void EmployeeAddressRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void EmployeeAddressRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void EmployeeAddressRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void EmployeeAddressRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}