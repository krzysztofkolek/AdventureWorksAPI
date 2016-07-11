namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class ScrapReasonRepositoryTest : BaseRepositoryTest<ScrapReason, ScrapReasonRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<ScrapReason, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<ScrapReason> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void ScrapReasonRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void ScrapReasonRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void ScrapReasonRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void ScrapReasonRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void ScrapReasonRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}