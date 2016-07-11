namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class IllustrationRepositoryTest : BaseRepositoryTest<Illustration, IllustrationRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<Illustration, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Illustration> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void IllustrationRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void IllustrationRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void IllustrationRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void IllustrationRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void IllustrationRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}