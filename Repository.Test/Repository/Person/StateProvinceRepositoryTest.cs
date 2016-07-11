namespace AdventureWorks.Repository.Test.Repository.Person
{
    using EntityClasses.Person;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Person")]
    public class StateProvinceRepositoryTest : BaseRepositoryTest<StateProvince, StateProvinceRepositoryTest>
    {

        public override System.Linq.Expressions.Expression<System.Func<StateProvince, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<StateProvince> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void StateProvinceRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void StateProvinceRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void StateProvinceRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void StateProvinceRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void StateProvinceRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}