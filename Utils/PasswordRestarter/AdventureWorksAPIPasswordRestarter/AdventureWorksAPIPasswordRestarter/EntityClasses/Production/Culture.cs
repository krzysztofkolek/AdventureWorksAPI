﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
	/// <summary>Class which represents the entity 'Production.Culture'</summary>
	public partial class Culture
	{
		#region Class Member Declarations
		private ISet<ProductModelProductDescriptionCulture> _productModelProductDescriptionCultures;
		private System.String _cultureId;
		private System.DateTime _modifiedDate;
		private System.String _name;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="Culture"/> class.</summary>
		public Culture() : base()
		{
			_productModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.CultureId.GetHashCode();
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
			Culture toCompareWith = obj as Culture;
			return toCompareWith == null ? false : ((this.CultureId == toCompareWith.CultureId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the CultureId field. </summary>	
		public virtual System.String CultureId
		{ 
			get { return _cultureId; }
			set { _cultureId = value; }
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

		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductModelProductDescriptionCulture.Culture - Production.Culture.ProductModelProductDescriptionCultures (m:1)'</summary>
		public virtual ISet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures
		{
			get { return _productModelProductDescriptionCultures; }
			set { _productModelProductDescriptionCultures = value; }
		}
		
		#endregion
	}
}
