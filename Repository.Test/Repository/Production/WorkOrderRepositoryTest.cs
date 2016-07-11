namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;
    using NUnit.Framework;

    public class WorkOrderRepositoryTest : BaseRepositoryTest<WorkOrder, WorkOrderRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<WorkOrder, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<WorkOrder> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void WorkOrderRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void WorkOrderRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void WorkOrderRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void WorkOrderRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void WorkOrderRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}