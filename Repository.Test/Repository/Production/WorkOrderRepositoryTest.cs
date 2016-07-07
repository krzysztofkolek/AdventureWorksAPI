namespace AdventureWorks.Repository.Test.Repository.Production
{
    using EntityClasses.Production;
    using Main;

    public class WorkOrderRepositoryTest : BaseRepositoryTest<WorkOrder, WorkOrderRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<WorkOrder, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<WorkOrder> input)
        {
            throw new System.NotImplementedException();
        }
    }
}