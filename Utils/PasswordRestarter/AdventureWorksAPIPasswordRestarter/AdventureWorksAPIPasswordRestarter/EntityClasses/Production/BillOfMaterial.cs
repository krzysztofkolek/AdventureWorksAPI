﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
    using Person;
    using Production;

    /// <summary>Class which represents the entity 'Production.BillOfMaterial'</summary>
	public partial class BillOfMaterial
	{
		#region Class Member Declarations
		private Product _product;
		private Product _product1;
		private UnitMeasure _unitMeasure;
		private System.Int32 _billOfMaterialsId;
		private System.Int16 _bomlevel;
		private Nullable<System.DateTime> _endDate;
		private System.DateTime _modifiedDate;
		private System.Decimal _perAssemblyQty;
		private System.DateTime _startDate;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="BillOfMaterial"/> class.</summary>
		public BillOfMaterial() : base()
		{
			_billOfMaterialsId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.BillOfMaterialsId.GetHashCode();
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
			BillOfMaterial toCompareWith = obj as BillOfMaterial;
			return toCompareWith == null ? false : ((this.BillOfMaterialsId == toCompareWith.BillOfMaterialsId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets the BillOfMaterialsId field. </summary>	
		public virtual System.Int32 BillOfMaterialsId
		{ 
			get { return _billOfMaterialsId; }
		}

		/// <summary>Gets or sets the Bomlevel field. </summary>	
		public virtual System.Int16 Bomlevel
		{ 
			get { return _bomlevel; }
			set { _bomlevel = value; }
		}

		/// <summary>Gets or sets the EndDate field. </summary>	
		public virtual Nullable<System.DateTime> EndDate
		{ 
			get { return _endDate; }
			set { _endDate = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the PerAssemblyQty field. </summary>	
		public virtual System.Decimal PerAssemblyQty
		{ 
			get { return _perAssemblyQty; }
			set { _perAssemblyQty = value; }
		}

		/// <summary>Gets or sets the StartDate field. </summary>	
		public virtual System.DateTime StartDate
		{ 
			get { return _startDate; }
			set { _startDate = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.BillOfMaterial.Product - Production.Product.BillOfMaterials (m:1)'</summary>
		public virtual Product Product
		{
			get { return _product; }
			set { _product = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.BillOfMaterial.Product1 - Production.Product.BillOfMaterials1 (m:1)'</summary>
		public virtual Product Product1
		{
			get { return _product1; }
			set { _product1 = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.BillOfMaterial.UnitMeasure - Production.UnitMeasure.BillOfMaterials (m:1)'</summary>
		public virtual UnitMeasure UnitMeasure
		{
			get { return _unitMeasure; }
			set { _unitMeasure = value; }
		}
		
		#endregion
	}
}
