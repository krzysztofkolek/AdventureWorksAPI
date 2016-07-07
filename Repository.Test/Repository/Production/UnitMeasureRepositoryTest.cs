namespace AdventureWorks.Repository.Test.Repository.Production
{
    using AdventureWorks.Repository.Main;
    using AdventureWorks.Repository.Test.Main;
    using EntityClasses.Production;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class UnitMeasureRepositoryTest : BaseRepositoryTest<UnitMeasure, UnitMeasureRepositoryTest>
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

        public override System.Linq.Expressions.Expression<System.Func<UnitMeasure, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<UnitMeasure> input)
        {
            throw new System.NotImplementedException();
        }
    }
}