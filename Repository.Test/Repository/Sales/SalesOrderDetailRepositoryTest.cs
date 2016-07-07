namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class SalesOrderDetailRepositoryTest : BaseRepositoryTest<SalesOrderDetail, SalesOrderDetailRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<SalesOrderDetail, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<SalesOrderDetail> input)
        {
            throw new System.NotImplementedException();
        }
    }
}