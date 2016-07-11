namespace AdventureWorks.Repository.Test.Repository.Person
{
    using EntityClasses.Person;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Person")]
    public class CountryRegionRepositoryTest : BaseRepositoryTest<CountryRegion, CountryRegionRepositoryTest>
    {

        public override System.Linq.Expressions.Expression<System.Func<CountryRegion, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<CountryRegion> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void CountryRegionRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void CountryRegionRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void CountryRegionRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void CountryRegionRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void CountryRegionRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}