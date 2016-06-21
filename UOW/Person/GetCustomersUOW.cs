namespace AdventureWorks.UOW.Person
{
    using System;
    using Main;
    using Model.Person;

    internal class GetCustomersUOW : BaseUOW<GetCustomersModel>
    {
        public override GetCustomersModel GetResult()
        {
            throw new NotImplementedException();
        }
    }
}