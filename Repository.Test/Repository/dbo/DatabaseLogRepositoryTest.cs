namespace AdventureWorks.Repository.Test.Repository.dbo
{
    using AdventureWorks.EntityClasses.dbo;
    using Main;
    using NUnit.Framework;


    [TestFixture]
    public class DatabaseLogRepositoryTest : BaseRepositoryTest<DatabaseLog, DatabaseLogRepositoryTest>
    {

        public override System.Linq.Expressions.Expression<System.Func<DatabaseLog, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<DatabaseLog> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void DatabaseLogRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void DatabaseLogRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void DatabaseLogRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void DatabaseLogRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void DatabaseLogRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}