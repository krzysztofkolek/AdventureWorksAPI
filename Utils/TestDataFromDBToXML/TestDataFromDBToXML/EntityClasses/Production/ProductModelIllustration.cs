


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
	/// <summary>Class which represents the entity 'Production.ProductModelIllustration'</summary>
	public partial class ProductModelIllustration
	{
		#region Class Member Declarations
		private Illustration _illustration;
		private ProductModel _productModel;
		private System.DateTime _modifiedDate;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="ProductModelIllustration"/> class.</summary>
		public ProductModelIllustration() : base()
		{
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			return toReturn;
		}
	
		/// <summary>Determines whether the specified object is equal to this instance.</summary>
		/// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
		/// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
		public override bool Equals(object obj)
		{
			return object.ReferenceEquals(this, obj);
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductModelIllustration.Illustration - Production.Illustration.ProductModelIllustrations (m:1)'</summary>
		public virtual Illustration Illustration
		{
			get { return _illustration; }
			set { _illustration = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductModelIllustration.ProductModel - Production.ProductModel.ProductModelIllustrations (m:1)'</summary>
		public virtual ProductModel ProductModel
		{
			get { return _productModel; }
			set { _productModel = value; }
		}
		
		#endregion
	}
}
