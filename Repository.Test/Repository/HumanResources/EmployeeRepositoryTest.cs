namespace AdventureWorks.Repository.Test.Repository.HumanResources
{
    using EntityClasses.HumanResources;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("HumanResources")]
    public class EmployeeRepositoryTest : BaseRepositoryTest<Employee, EmployeeRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<Employee, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Employee> input)
        {
            throw new System.NotImplementedException();
        }
    }
}