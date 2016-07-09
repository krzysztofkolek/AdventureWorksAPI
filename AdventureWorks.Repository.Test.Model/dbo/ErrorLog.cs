namespace AdventureWorks.Repository.Test.Model.dbo
{
    using System;

    public class ErrorLog
    {
        public Nullable<System.Int32> ErrorLine{ get; set; }
        public System.Int32 ErrorLogId{ get; set; }
        public System.String ErrorMessage{ get; set; }
        public System.Int32 ErrorNumber{ get; set; }
        public System.String ErrorProcedure{ get; set; }
        public Nullable<System.Int32> ErrorSeverity{ get; set; }
        public Nullable<System.Int32> ErrorState{ get; set; }
        public System.DateTime ErrorTime{ get; set; }
        public System.String UserName{ get; set; }
    }
}
