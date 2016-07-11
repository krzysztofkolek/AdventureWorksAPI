namespace AdventureWorks.Repository.Test.Repository.HumanResources
{
    using AdventureWorks.EntityClasses.HumanResources;
    using AdventureWorks.Repository.Test.Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("HumanResources")]
    public class EmployeeExtendedRepository : BaseRepositoryTest<Employee, EmployeeExtendedRepository>
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
        public void EmployeeExtendedRepository_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void EmployeeExtendedRepository_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void EmployeeExtendedRepository_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void EmployeeExtendedRepository_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void EmployeeExtendedRepository_Delete()
        {
            BaseDelete();
        }
    }
}
