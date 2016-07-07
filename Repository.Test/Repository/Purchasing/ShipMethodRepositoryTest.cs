namespace AdventureWorks.Repository.Test.Repository.Purchasing
{
    using EntityClasses.Purchasing;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Purchasing")]
    public class ShipMethodRepositoryTest : BaseRepositoryTest<ShipMethod, ShipMethodRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<ShipMethod, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ShipMethod> input)
        {
            throw new System.NotImplementedException();
        }
    }
}