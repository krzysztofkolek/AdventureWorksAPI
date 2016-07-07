namespace AdventureWorks.Repository.Test.Repository.HumanResources
{
    using EntityClasses.HumanResources;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("HumanResources")]
    public class JobCandidateRepositoryTest : BaseRepositoryTest<JobCandidate, JobCandidateRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<JobCandidate, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<JobCandidate> input)
        {
            throw new System.NotImplementedException();
        }
    }
}