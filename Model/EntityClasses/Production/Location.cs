﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
	/// <summary>Class which represents the entity 'Production.Location'</summary>
	public partial class Location
	{
		#region Class Member Declarations
		private ISet<ProductInventory> _productInventories;
		private ISet<WorkOrderRouting> _workOrderRoutings;
		private System.Decimal _availability;
		private System.Decimal _costRate;
		private System.Int16 _locationId;
		private System.DateTime _modifiedDate;
		private System.String _name;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="Location"/> class.</summary>
		public Location() : base()
		{
			_productInventories = new HashSet<ProductInventory>();
			_workOrderRoutings = new HashSet<WorkOrderRouting>();
			_locationId = default(System.Int16);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.LocationId.GetHashCode();
			return toReturn;
		}
	
		/// <summary>Determines whether the specified object is equal to this instance.</summary>
		/// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
		/// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
		public override bool Equals(object obj)
		{
			if(obj == null) 
			{
				return false;
			}
			Location toCompareWith = obj as Location;
			return toCompareWith == null ? false : ((this.LocationId == toCompareWith.LocationId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the Availability field. </summary>	
		public virtual System.Decimal Availability
		{ 
			get { return _availability; }
			set { _availability = value; }
		}

		/// <summary>Gets or sets the CostRate field. </summary>	
		public virtual System.Decimal CostRate
		{ 
			get { return _costRate; }
			set { _costRate = value; }
		}

		/// <summary>Gets the LocationId field. </summary>	
		public virtual System.Int16 LocationId
		{ 
			get { return _locationId; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the Name field. </summary>	
		public virtual System.String Name
		{ 
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductInventory.Location - Production.Location.ProductInventories (m:1)'</summary>
		public virtual ISet<ProductInventory> ProductInventories
		{
			get { return _productInventories; }
			set { _productInventories = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.WorkOrderRouting.Location - Production.Location.WorkOrderRoutings (m:1)'</summary>
		public virtual ISet<WorkOrderRouting> WorkOrderRoutings
		{
			get { return _workOrderRoutings; }
			set { _workOrderRoutings = value; }
		}
		
		#endregion
	}
}