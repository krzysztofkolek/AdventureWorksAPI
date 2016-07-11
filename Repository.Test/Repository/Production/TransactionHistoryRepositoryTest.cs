namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class TransactionHistoryRepositoryTest : BaseRepositoryTest<TransactionHistory, TransactionHistoryRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<TransactionHistory, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<TransactionHistory> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void TransactionHistoryRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void TransactionHistoryRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void TransactionHistoryRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void TransactionHistoryRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void TransactionHistoryRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}