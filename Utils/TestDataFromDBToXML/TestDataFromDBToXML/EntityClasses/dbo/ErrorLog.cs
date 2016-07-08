namespace AdventureWorks.EntityClasses.dbo
{
    using System;
 
	/// <summary>Class which represents the entity 'ErrorLog'</summary>
	public partial class ErrorLog
	{
		#region Class Member Declarations
		private Nullable<System.Int32> _errorLine;
		private System.Int32 _errorLogId;
		private System.String _errorMessage;
		private System.Int32 _errorNumber;
		private System.String _errorProcedure;
		private Nullable<System.Int32> _errorSeverity;
		private Nullable<System.Int32> _errorState;
		private System.DateTime _errorTime;
		private System.String _userName;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="ErrorLog"/> class.</summary>
		public ErrorLog() : base()
		{
			_errorLogId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.ErrorLogId.GetHashCode();
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
			ErrorLog toCompareWith = obj as ErrorLog;
			return toCompareWith == null ? false : ((this.ErrorLogId == toCompareWith.ErrorLogId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the ErrorLine field. </summary>	
		public virtual Nullable<System.Int32> ErrorLine
		{ 
			get { return _errorLine; }
			set { _errorLine = value; }
		}

		/// <summary>Gets the ErrorLogId field. </summary>	
		public virtual System.Int32 ErrorLogId
		{ 
			get { return _errorLogId; }
		}

		/// <summary>Gets or sets the ErrorMessage field. </summary>	
		public virtual System.String ErrorMessage
		{ 
			get { return _errorMessage; }
			set { _errorMessage = value; }
		}

		/// <summary>Gets or sets the ErrorNumber field. </summary>	
		public virtual System.Int32 ErrorNumber
		{ 
			get { return _errorNumber; }
			set { _errorNumber = value; }
		}

		/// <summary>Gets or sets the ErrorProcedure field. </summary>	
		public virtual System.String ErrorProcedure
		{ 
			get { return _errorProcedure; }
			set { _errorProcedure = value; }
		}

		/// <summary>Gets or sets the ErrorSeverity field. </summary>	
		public virtual Nullable<System.Int32> ErrorSeverity
		{ 
			get { return _errorSeverity; }
			set { _errorSeverity = value; }
		}

		/// <summary>Gets or sets the ErrorState field. </summary>	
		public virtual Nullable<System.Int32> ErrorState
		{ 
			get { return _errorState; }
			set { _errorState = value; }
		}

		/// <summary>Gets or sets the ErrorTime field. </summary>	
		public virtual System.DateTime ErrorTime
		{ 
			get { return _errorTime; }
			set { _errorTime = value; }
		}

		/// <summary>Gets or sets the UserName field. </summary>	
		public virtual System.String UserName
		{ 
			get { return _userName; }
			set { _userName = value; }
		}

		#endregion
	}
}
