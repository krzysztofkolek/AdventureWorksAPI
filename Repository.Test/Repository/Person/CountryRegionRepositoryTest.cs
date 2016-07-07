namespace AdventureWorks.Repository.Test.Repository.Person
{
    using EntityClasses.Person;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Person")]
    public class CountryRegionRepositoryTest : BaseRepositoryTest<CountryRegion, CountryRegionRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<CountryRegion, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<CountryRegion> input)
        {
            throw new System.NotImplementedException();
        }
    }
}