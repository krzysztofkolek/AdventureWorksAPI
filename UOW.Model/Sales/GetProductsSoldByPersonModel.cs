namespace AdventureWorks.UOW.Model.Sales
{
    using System;
    using System.Collections.Generic;

    public class GetProductsSoldByPersonModel
    {
        public String EmployeeName { get; set; }
        public List<GetProductsSoldByPersonItemModel> Products { get; set; }
    }
}
