namespace AdventureWorks.UOW.Sales
{
    using System;
    using System.Collections.Generic;
    using Main;
    using Model.Sales;

    public class GetAllTerritorysForSalesUOW : BaseUOW<List<GetAllTerritorysForModel>>
    {
        public override List<GetAllTerritorysForModel> GetResult()
        {
            throw new NotImplementedException();
        }
    }
}