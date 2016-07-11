namespace AdventureWorks.Repository.Test.Repository.HumanResources
{
    using EntityClasses.HumanResources;
    using Main;
    using NUnit.Framework;

    [TestFixture]
    [Category("HumanResources")]
    public class ShiftRepositoryTest : BaseRepositoryTest<Shift, ShiftRepositoryTest>
    {
        public override System.Linq.Expressions.Expression<System.Func<Shift, bool>> SearchForExpresion()
        {
            throw new System.NotImplementedException();
        }

        public override void BaseSearchForAsserts(System.Collections.Generic.IList<Shift> input)
        {
            throw new System.NotImplementedException();
        }

        [Test]
        [Order(1)]
        public void ShiftRepositoryTest_Insert()
        {
            BaseInsert();
        }

        [Test]
        [Order(2)]
        public void ShiftRepositoryTest_GetById()
        {
            BaseGetById();
        }

        [Test]
        [Order(3)]
        public void ShiftRepositoryTest_SearchFor()
        {
            BaseSearchFor();
        }

        [Test]
        [Order(4)]
        public void ShiftRepositoryTest_GetAll()
        {
            BaseGetAll();
        }

        [Test]
        [Order(5)]
        public void ShiftRepositoryTest_Delete()
        {
            BaseDelete();
        }
    }
}