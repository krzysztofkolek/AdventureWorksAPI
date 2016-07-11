namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class WorkOrderRoutingRepositoryTest : BaseRepositoryTest<WorkOrderRouting, WorkOrderRoutingRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<WorkOrderRouting, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<WorkOrderRouting> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void WorkOrderRoutingRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void WorkOrderRoutingRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void WorkOrderRoutingRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void WorkOrderRoutingRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void WorkOrderRoutingRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}