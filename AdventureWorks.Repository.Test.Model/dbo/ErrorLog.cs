namespace AdventureWorks.Repository.Test.Model.dbo
{
    using System;

    public class ErrorLog
    {
        public Nullable<System.Int32> _errorLine{ get; set; }
        public System.Int32 _errorLogId{ get; set; }
        public System.String _errorMessage{ get; set; }
        public System.Int32 _errorNumber{ get; set; }
        public System.String _errorProcedure{ get; set; }
        public Nullable<System.Int32> _errorSeverity{ get; set; }
        public Nullable<System.Int32> _errorState{ get; set; }
        public System.DateTime _errorTime{ get; set; }
        public System.String _userName{ get; set; }
    }
}
