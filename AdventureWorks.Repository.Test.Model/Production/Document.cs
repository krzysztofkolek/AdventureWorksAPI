namespace AdventureWorks.Repository.Test.Model.Production
{
    public class Document
    {
        public System.Int32 ChangeNumber { get; set; }
        public System.Int32 DocumentId { get; set; }
        public System.Byte[] DocumentsBytes { get; set; }
        public System.String DocumentSummary { get; set; }
        public System.String FileExtension { get; set; }
        public System.String FileName { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public System.String Revision { get; set; }
        public System.Byte Status { get; set; }
        public System.String Title { get; set; }
    }
}
