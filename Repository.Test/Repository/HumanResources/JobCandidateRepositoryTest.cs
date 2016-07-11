namespace AdventureWorks.Repository.Test.Repository.HumanResources
{
    using EntityClasses.HumanResources;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("HumanResources")]
    public class JobCandidateRepositoryTest : BaseRepositoryTest<JobCandidate, JobCandidateRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<JobCandidate, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<JobCandidate> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void JobCandidateRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void JobCandidateRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void JobCandidateRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void JobCandidateRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void JobCandidateRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}