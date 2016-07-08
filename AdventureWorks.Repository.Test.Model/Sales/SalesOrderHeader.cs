namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;
    using Purchasing;
    using System;

	public class SalesOrderHeader
	{
		public Address _address{ get; set; }
		public Address _address1{ get; set; }
		public Contact _contact{ get; set; }
		public ShipMethod _shipMethod{ get; set; }
		public CreditCard _creditCard{ get; set; }
		public CurrencyRate _currencyRate{ get; set; }
		public Customer _customer{ get; set; }
		public SalesPerson _salesPerson{ get; set; }
		public SalesTerritory _salesTerritory{ get; set; }
		public System.String _accountNumber{ get; set; }
		public System.String _comment{ get; set; }
		public System.String _creditCardApprovalCode{ get; set; }
		public System.DateTime _dueDate{ get; set; }
		public System.Decimal _freight{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Boolean _onlineOrderFlag{ get; set; }
		public System.DateTime _orderDate{ get; set; }
		public System.String _purchaseOrderNumber{ get; set; }
		public System.Byte _revisionNumber{ get; set; }
		public System.Guid _rowguid{ get; set; }
		public System.Int32 _salesOrderId{ get; set; }
		public System.String _salesOrderNumber{ get; set; }
		public Nullable<System.DateTime> _shipDate{ get; set; }
		public System.Byte _status{ get; set; }
		public System.Decimal _subTotal{ get; set; }
		public System.Decimal _taxAmt{ get; set; }
		public System.Decimal _totalDue{ get; set; }
	}
}
