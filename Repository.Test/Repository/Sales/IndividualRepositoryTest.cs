namespace AdventureWorks.Repository.Test.Repository.Sales
{
    using EntityClasses.Sales;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Sales")]
    public class IndividualRepositoryTest : BaseRepositoryTest<Individual, IndividualRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<Individual, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Individual> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void IndividualRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void IndividualRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void IndividualRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void IndividualRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void IndividualRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}