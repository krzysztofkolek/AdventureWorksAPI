namespace AdventureWorks.API.Model.Module.User
{
    using System;
    using UOW.Model.Person;

    public class EmployeeModel
    {
        public EmployeeModel()
        {
        }

        public EmployeeModel(EmployeeViewModel employeeViewModel)
        {
            BirthDate = employeeViewModel.BirthDate;
            Gender = employeeViewModel.Gender;
            HireDate = employeeViewModel.HireDate;
        }

        public DateTime BirthDate { get; set; }
        public String Gender { get; set; }
        public DateTime HireDate { get; set; }
    }
}