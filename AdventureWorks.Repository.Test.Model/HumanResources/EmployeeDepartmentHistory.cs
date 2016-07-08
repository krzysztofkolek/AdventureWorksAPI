namespace AdventureWorks.Repository.Test.Model.HumanResources
{
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;

	public  class EmployeeDepartmentHistory
	{
		public Department _department{ get; set; }
		public Employee _employee{ get; set; }
		public Shift _shift{ get; set; }
		public Nullable<System.DateTime> _endDate{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.DateTime _startDate{ get; set; }

		
	}
}
