﻿


using System.Collections.Generic;
using System.Xml.Serialization;

namespace AdventureWorks.EntityClasses.HumanResources
{
    /// <summary>Class which represents the entity 'HumanResources.Department'</summary>
    public partial class Department
    {
        #region Class Member Declarations
         
        private ISet<EmployeeDepartmentHistory> _employeeDepartmentHistories;
        private System.Int16 _departmentId;
        private System.String _groupName;
        private System.DateTime _modifiedDate;
        private System.String _name;
        #endregion

        /// <summary>Initializes a new instance of the <see cref="Department"/> class.</summary>
        public Department()
            : base()
        {
            _employeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
            _departmentId = default(System.Int16);
            OnCreated();
        }

        /// <summary>Method called from the constructor</summary>
        partial void OnCreated();

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DepartmentId.GetHashCode();
            return toReturn;
        }

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Department toCompareWith = obj as Department;
            return toCompareWith == null ? false : ((this.DepartmentId == toCompareWith.DepartmentId));
        }


        #region Class Property Declarations
        /// <summary>Gets the DepartmentId field. </summary>	
        public virtual System.Int16 DepartmentId
        {
            get { return _departmentId; }
        }

        /// <summary>Gets or sets the GroupName field. </summary>	
        public virtual System.String GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'HumanResources.EmployeeDepartmentHistory.Department - HumanResources.Department.EmployeeDepartmentHistories (m:1)'</summary>
        public virtual ISet<EmployeeDepartmentHistory> EmployeeDepartmentHistories
        {
            get { return _employeeDepartmentHistories; }
            set { _employeeDepartmentHistories = value; }
        }

        #endregion
    }
}