namespace AdventureWorks.Repository.Test.Repository.HumanResources
{
    using EntityClasses.HumanResources;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("HumanResources")]
    public class EmployeeRepositoryTest : BaseRepositoryTest<Employee, EmployeeRepositoryTest>
    {

        public override System.Linq.Expressions.Expression<System.Func<Employee, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Employee> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void EmployeeRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void EmployeeRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void EmployeeRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void EmployeeRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void EmployeeRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}