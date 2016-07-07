namespace AdventureWorks.Repository.Test.Repository.HumanResources
{
    using AdventureWorks.EntityClasses.HumanResources;
    using AdventureWorks.Repository.Test.Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("HumanResources")]
    public class EmployeeDepartmentHistoryRepositoryTest : BaseRepositoryTest<EmployeeAddress, EmployeeAddressRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<EmployeeAddress, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<EmployeeAddress> input)
        {
            throw new System.NotImplementedException();
        }
    }
}