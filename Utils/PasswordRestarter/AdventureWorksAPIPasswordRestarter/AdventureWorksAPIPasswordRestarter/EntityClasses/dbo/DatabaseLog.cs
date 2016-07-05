namespace AdventureWorks.EntityClasses.dbo
{
	/// <summary>Class which represents the entity 'DatabaseLog'</summary>
	public partial class DatabaseLog
	{
		#region Class Member Declarations
		private System.Int32 _databaseLogId;
		private System.String _databaseUser;
		private System.String _event;
		private System.String _object;
		private System.DateTime _postTime;
		private System.String _schema;
		private System.String _tsql;
		private System.String _xmlEvent;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="DatabaseLog"/> class.</summary>
		public DatabaseLog() : base()
		{
			_databaseLogId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.DatabaseLogId.GetHashCode();
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
			DatabaseLog toCompareWith = obj as DatabaseLog;
			return toCompareWith == null ? false : ((this.DatabaseLogId == toCompareWith.DatabaseLogId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets the DatabaseLogId field. </summary>	
		public virtual System.Int32 DatabaseLogId
		{ 
			get { return _databaseLogId; }
		}

		/// <summary>Gets or sets the DatabaseUser field. </summary>	
		public virtual System.String DatabaseUser
		{ 
			get { return _databaseUser; }
			set { _databaseUser = value; }
		}

		/// <summary>Gets or sets the Event field. </summary>	
		public virtual System.String Event
		{ 
			get { return _event; }
			set { _event = value; }
		}

		/// <summary>Gets or sets the Object field. </summary>	
		public virtual System.String Object
		{ 
			get { return _object; }
			set { _object = value; }
		}

		/// <summary>Gets or sets the PostTime field. </summary>	
		public virtual System.DateTime PostTime
		{ 
			get { return _postTime; }
			set { _postTime = value; }
		}

		/// <summary>Gets or sets the Schema field. </summary>	
		public virtual System.String Schema
		{ 
			get { return _schema; }
			set { _schema = value; }
		}

		/// <summary>Gets or sets the Tsql field. </summary>	
		public virtual System.String Tsql
		{ 
			get { return _tsql; }
			set { _tsql = value; }
		}

		/// <summary>Gets or sets the XmlEvent field. </summary>	
		public virtual System.String XmlEvent
		{ 
			get { return _xmlEvent; }
			set { _xmlEvent = value; }
		}

		#endregion
	}
}
