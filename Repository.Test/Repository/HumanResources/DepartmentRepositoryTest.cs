namespace AdventureWorks.Repository.Test.Repository.HumanResources
{
    using AdventureWorks.EntityClasses.HumanResources;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("HumanResources")]
    public class DepartmentRepositorTest : BaseRepositoryTest<Department, DepartmentRepositorTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<Department, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Department> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void DepartmentRepositorTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void DepartmentRepositorTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void DepartmentRepositorTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void DepartmentRepositorTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void DepartmentRepositorTest_Delete()
        {
            BaseDelete();
        }
    }
}