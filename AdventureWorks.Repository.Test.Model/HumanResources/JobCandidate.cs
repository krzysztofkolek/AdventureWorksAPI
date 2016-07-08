namespace AdventureWorks.Repository.Test.Model.HumanResources
{

    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
	

	public  class JobCandidate
	{
		public Employee _employee{ get; set; }
		public System.Int32 _jobCandidateId{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.String _resume{ get; set; }
	}
}
