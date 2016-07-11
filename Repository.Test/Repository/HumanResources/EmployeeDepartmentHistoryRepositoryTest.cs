namespace AdventureWorks.Repository.Test.Repository.HumanResources
{
    using AdventureWorks.EntityClasses.HumanResources;
    using AdventureWorks.Repository.Test.Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("HumanResources")]
    public class EmployeeDepartmentHistoryRepositoryTest : BaseRepositoryTest<EmployeeAddress, EmployeeAddressRepositoryTest>
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
        public void EmployeeDepartmentHistoryRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void EmployeeDepartmentHistoryRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void EmployeeDepartmentHistoryRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void EmployeeDepartmentHistoryRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void EmployeeDepartmentHistoryRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}