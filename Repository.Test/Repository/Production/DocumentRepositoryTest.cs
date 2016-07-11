namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class DocumentRepositoryTest : BaseRepositoryTest<Document, DocumentRepositoryTest>
    {

        public override System.Linq.Expressions.Expression<System.Func<Document, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Document> input)
        {
            throw new System.NotImplementedException();
        }
        
        [Test]
        [Order(1)]
        public void DocumentRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void DocumentRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void DocumentRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void DocumentRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void DocumentRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}