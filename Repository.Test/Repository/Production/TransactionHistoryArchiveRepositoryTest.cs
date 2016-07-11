namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class TransactionHistoryArchiveRepositoryTest : BaseRepositoryTest<TransactionHistoryArchive, TransactionHistoryArchiveRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<TransactionHistoryArchive, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<TransactionHistoryArchive> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void TransactionHistoryArchiveRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void TransactionHistoryArchiveRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void TransactionHistoryArchiveRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void TransactionHistoryArchiveRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void TransactionHistoryArchiveRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}