namespace AdventureWorks.Repository.Test.Repository.HumanResources
{
    using AdventureWorks.EntityClasses.HumanResources;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("HumanResources")]
    public class DepartmentRepositorTest : BaseRepositoryTest<Department, DepartmentRepositorTest>
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

        public override System.Linq.Expressions.Expression<System.Func<Department, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Department> input)
        {
            throw new System.NotImplementedException();
        }
    }
}