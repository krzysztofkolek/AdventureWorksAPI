﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
	/// <summary>Class which represents the entity 'Production.Document'</summary>
	public partial class Document
	{
		#region Class Member Declarations
		private ISet<ProductDocument> _productDocuments;
		private System.Int32 _changeNumber;
		private System.Int32 _documentId;
		private System.Byte[] _documentsBytes;
		private System.String _documentSummary;
		private System.String _fileExtension;
		private System.String _fileName;
		private System.DateTime _modifiedDate;
		private System.String _revision;
		private System.Byte _status;
		private System.String _title;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="Document"/> class.</summary>
		public Document() : base()
		{
			_productDocuments = new HashSet<ProductDocument>();
			_documentId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.DocumentId.GetHashCode();
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
			Document toCompareWith = obj as Document;
			return toCompareWith == null ? false : ((this.DocumentId == toCompareWith.DocumentId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the ChangeNumber field. </summary>	
		public virtual System.Int32 ChangeNumber
		{ 
			get { return _changeNumber; }
			set { _changeNumber = value; }
		}

		/// <summary>Gets the DocumentId field. </summary>	
		public virtual System.Int32 DocumentId
		{ 
			get { return _documentId; }
		}

		/// <summary>Gets or sets the DocumentsBytes field. </summary>	
		public virtual System.Byte[] DocumentsBytes
		{ 
			get { return _documentsBytes; }
			set { _documentsBytes = value; }
		}

		/// <summary>Gets or sets the DocumentSummary field. </summary>	
		public virtual System.String DocumentSummary
		{ 
			get { return _documentSummary; }
			set { _documentSummary = value; }
		}

		/// <summary>Gets or sets the FileExtension field. </summary>	
		public virtual System.String FileExtension
		{ 
			get { return _fileExtension; }
			set { _fileExtension = value; }
		}

		/// <summary>Gets or sets the FileName field. </summary>	
		public virtual System.String FileName
		{ 
			get { return _fileName; }
			set { _fileName = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the Revision field. </summary>	
		public virtual System.String Revision
		{ 
			get { return _revision; }
			set { _revision = value; }
		}

		/// <summary>Gets or sets the Status field. </summary>	
		public virtual System.Byte Status
		{ 
			get { return _status; }
			set { _status = value; }
		}

		/// <summary>Gets or sets the Title field. </summary>	
		public virtual System.String Title
		{ 
			get { return _title; }
			set { _title = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductDocument.Document - Production.Document.ProductDocuments (m:1)'</summary>
		public virtual ISet<ProductDocument> ProductDocuments
		{
			get { return _productDocuments; }
			set { _productDocuments = value; }
		}
		
		#endregion
	}
}
