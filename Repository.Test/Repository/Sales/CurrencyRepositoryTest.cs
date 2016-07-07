namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class CurrencyRepositoryTest : BaseRepositoryTest<Currency, CurrencyRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<Currency, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Currency> input)
        {
            throw new System.NotImplementedException();
        }
    }
}