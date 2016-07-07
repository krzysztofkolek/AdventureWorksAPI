namespace AdventureWorks.Repository.Test.Repository.dbo
{
    using EntityClasses.dbo;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("dbo")]
    public class AwbuildVersionRepositoryTest : BaseRepositoryTest<AwbuildVersion, AwbuildVersionRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<AwbuildVersion, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<AwbuildVersion> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void Delete()
        {
            BaseDelete();
        }
    }
}