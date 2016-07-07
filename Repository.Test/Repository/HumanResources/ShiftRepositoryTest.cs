namespace AdventureWorks.Repository.Test.Repository.HumanResources
{
    using EntityClasses.HumanResources;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("HumanResources")]
    public class ShiftRepositoryTest : BaseRepositoryTest<Shift, ShiftRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<Shift, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Shift> input)
        {
            throw new System.NotImplementedException();
        }
    }
}