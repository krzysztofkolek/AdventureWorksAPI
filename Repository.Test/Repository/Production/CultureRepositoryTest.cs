namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class CultureRepositoryTest : BaseRepositoryTest<Culture, CultureRepositoryTest>
    {

        public override System.Linq.Expressions.Expression<System.Func<Culture, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Culture> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void CultureRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void CultureRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void CultureRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void CultureRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void CultureRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}