
namespace AdventureWorks.Repository.Test.Repository.HumanResources
{
    using Main;
    using AdventureWorks.EntityClasses.HumanResources;
    using NUnit.Framework;

    [TestFixture]
    [Category("HumanResources")]
    public class EmployeePayHistoryRepositoryTest : BaseRepositoryTest<EmployeePayHistory, EmployeePayHistoryRepositoryTest>
    {

        public override System.Linq.Expressions.Expression<System.Func<EmployeePayHistory, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<EmployeePayHistory> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void EmployeePayHistoryRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void EmployeePayHistoryRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void EmployeePayHistoryRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void EmployeePayHistoryRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void EmployeePayHistoryRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}