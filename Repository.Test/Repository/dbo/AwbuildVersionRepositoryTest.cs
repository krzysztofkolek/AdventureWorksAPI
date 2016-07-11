namespace AdventureWorks.Repository.Test.Repository.dbo
{
    using EntityClasses.dbo;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("dbo")]
    public class AwbuildVersionRepositoryTest : BaseRepositoryTest<AwbuildVersion, AwbuildVersionRepositoryTest>
    {

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
        public void AwbuildVersionRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void AwbuildVersionRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void AwbuildVersionRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void AwbuildVersionRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void AwbuildVersionRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}