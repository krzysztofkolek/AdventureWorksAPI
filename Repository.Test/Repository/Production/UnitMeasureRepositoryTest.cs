namespace AdventureWorks.Repository.Test.Repository.Production
{
    using AdventureWorks.Repository.Test.Main;
    using EntityClasses.Production;
    using NUnit.Framework;

    [TestFixture]
    [Category("Production")]
    public class UnitMeasureRepositoryTest : BaseRepositoryTest<UnitMeasure, UnitMeasureRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<UnitMeasure, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<UnitMeasure> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void UnitMeasureRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void UnitMeasureRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void UnitMeasureRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void UnitMeasureRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void UnitMeasureRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}