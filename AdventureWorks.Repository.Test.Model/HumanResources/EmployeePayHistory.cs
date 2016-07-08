

namespace AdventureWorks.Repository.Test.Model.HumanResources
{
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;

	public  class EmployeePayHistory
	{
		public Employee _employee{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Byte _payFrequency{ get; set; }
		public System.Decimal _rate{ get; set; }
		public System.DateTime _rateChangeDate{ get; set; }
	}
}
