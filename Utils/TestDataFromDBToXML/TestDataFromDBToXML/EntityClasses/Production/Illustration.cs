﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
	/// <summary>Class which represents the entity 'Production.Illustration'</summary>
	public partial class Illustration
	{
		#region Class Member Declarations
		private ISet<ProductModelIllustration> _productModelIllustrations;
		private System.String _diagram;
		private System.Int32 _illustrationId;
		private System.DateTime _modifiedDate;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="Illustration"/> class.</summary>
		public Illustration() : base()
		{
			_productModelIllustrations = new HashSet<ProductModelIllustration>();
			_illustrationId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.IllustrationId.GetHashCode();
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
			Illustration toCompareWith = obj as Illustration;
			return toCompareWith == null ? false : ((this.IllustrationId == toCompareWith.IllustrationId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the Diagram field. </summary>	
		public virtual System.String Diagram
		{ 
			get { return _diagram; }
			set { _diagram = value; }
		}

		/// <summary>Gets the IllustrationId field. </summary>	
		public virtual System.Int32 IllustrationId
		{ 
			get { return _illustrationId; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductModelIllustration.Illustration - Production.Illustration.ProductModelIllustrations (m:1)'</summary>
		public virtual ISet<ProductModelIllustration> ProductModelIllustrations
		{
			get { return _productModelIllustrations; }
			set { _productModelIllustrations = value; }
		}
		
		#endregion
	}
}