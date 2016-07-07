
namespace AdventureWorks.Repository.Test.Repository.HumanResources
{
    using Main;
    using AdventureWorks.EntityClasses.HumanResources;
    using NUnit.Framework;

    [TestFixture]
    [Category("HumanResources")]
    public class EmployeePayHistoryRepositoryTest : BaseRepositoryTest<EmployeePayHistory, EmployeePayHistoryRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<EmployeePayHistory, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<EmployeePayHistory> input)
        {
            throw new System.NotImplementedException();
        }
    }
}