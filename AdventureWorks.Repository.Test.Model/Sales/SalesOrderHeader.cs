namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;
    using Purchasing;
    using System;

	public class SalesOrderHeader
	{
		public Address Address{ get; set; }
		public Address Address1{ get; set; }
		public Contact Contact{ get; set; }
		public ShipMethod ShipMethod{ get; set; }
		public CreditCard CreditCard{ get; set; }
		public CurrencyRate CurrencyRate{ get; set; }
		public Customer Customer{ get; set; }
		public SalesPerson SalesPerson{ get; set; }
		public SalesTerritory SalesTerritory{ get; set; }
		public System.String AccountNumber{ get; set; }
		public System.String Comment{ get; set; }
		public System.String CreditCardApprovalCode{ get; set; }
		public System.DateTime DueDate{ get; set; }
		public System.Decimal Freight{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.Boolean OnlineOrderFlag{ get; set; }
		public System.DateTime OrderDate{ get; set; }
		public System.String PurchaseOrderNumber{ get; set; }
		public System.Byte RevisionNumber{ get; set; }
		public System.Guid Rowguid{ get; set; }
		public System.Int32 SalesOrderId{ get; set; }
		public System.String SalesOrderNumber{ get; set; }
		public Nullable<System.DateTime> ShipDate{ get; set; }
		public System.Byte Status{ get; set; }
		public System.Decimal SubTotal{ get; set; }
		public System.Decimal TaxAmt{ get; set; }
		public System.Decimal TotalDue{ get; set; }
	}
}
