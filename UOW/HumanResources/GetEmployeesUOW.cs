namespace AdventureWorks.UOW.HumanResources
{
    using System;
    using Main;
    using Model.HumanResources;

    public class GetEmployeesUOW : BaseUOW<GetEmployeesModel>
    {
        public override GetEmployeesModel GetResult()
        {
            throw new NotImplementedException();
        }
    }
}