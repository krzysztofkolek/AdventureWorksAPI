namespace AdventureWorks.EntityClasses.dbo
{
	/// <summary>Class which represents the entity 'AwbuildVersion'</summary>
	public partial class AwbuildVersion
	{
		#region Class Member Declarations
		private System.String _databaseVersion;
		private System.DateTime _modifiedDate;
		private System.Byte _systemInformationId;
		private System.DateTime _versionDate;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="AwbuildVersion"/> class.</summary>
		public AwbuildVersion() : base()
		{
			_systemInformationId = default(System.Byte);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.SystemInformationId.GetHashCode();
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
			AwbuildVersion toCompareWith = obj as AwbuildVersion;
			return toCompareWith == null ? false : ((this.SystemInformationId == toCompareWith.SystemInformationId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the DatabaseVersion field. </summary>	
		public virtual System.String DatabaseVersion
		{ 
			get { return _databaseVersion; }
			set { _databaseVersion = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets the SystemInformationId field. </summary>	
		public virtual System.Byte SystemInformationId
		{ 
			get { return _systemInformationId; }
		}

		/// <summary>Gets or sets the VersionDate field. </summary>	
		public virtual System.DateTime VersionDate
		{ 
			get { return _versionDate; }
			set { _versionDate = value; }
		}

		#endregion
	}
}
