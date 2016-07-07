namespace AdventureWorks.Repository.Test.Repository.dbo
{
    using AdventureWorks.EntityClasses.dbo;
    using Main;
    using NUnit.Framework;


    [TestFixture]
    [Category("dbo")]
    public class DatabaseLogRepositoryTest : BaseRepositoryTest<DatabaseLog, DatabaseLogRepositoryTest>
    {
        public override string DataFileName()
        {
            throw new System.NotImplementedException();
        }

        public override string DataCategory()
        {
            throw new System.NotImplementedException();
        }

        public override int GetObjectId()
        {
            throw new System.NotImplementedException();
        }

        public override System.Linq.Expressions.Expression<System.Func<DatabaseLog, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<DatabaseLog> input)
        {
            throw new System.NotImplementedException();
        }
    }
}