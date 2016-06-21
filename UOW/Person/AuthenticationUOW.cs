namespace AdventureWorks.UOW.Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using API.Model.Module.Auth;
    using EntityClasses.HumanResources;
    using EntityClasses.Person;
    using Model.Person;
    using Repository.dbo;

    public class AuthenticationUOW : IAuthenticationUow
    {
        private readonly ContactRepository<Contact> _contactRepository;
        private readonly EmployeeRepository<Employee> _employeeRepository;

        public AuthenticationUOW(ContactRepository<Contact> contactRepository,
            EmployeeRepository<Employee> employeeRepository)
        {
            _contactRepository = contactRepository;
            _employeeRepository = employeeRepository;
        }

        public AuthenticationUOWModel ValidateHashedPassword(string username, string password)
        {
            Contact dbUser = _contactRepository.SearchFor(x => x.EmailAddress == username).FirstOrDefault();
            if (dbUser != null)
            {
                string passwordGenerated =
                    MD5(string.Format("{0}{1}{2}", username, password.Trim(), dbUser.PasswordSalt)) + "=";

                if (dbUser.PasswordHash.Equals(passwordGenerated))
                {
                    var userClaim = UserClaims.Customer;
                    if (dbUser.Employees != null)
                    {
                        userClaim = UserClaims.Employee;

                        Employee chief =
                            _employeeRepository.SearchFor(x => x.Contact.ContactId.Equals(dbUser.ContactId))
                                .FirstOrDefault();
                        if (chief != null && chief.EmployeeNav == null)
                        {
                            //userClaim = UserClaims.Chief;
                        }
                    }


                    return new AuthenticationUOWModel
                    {
                        UserName = username,
                        Claims = new List<String> {userClaim.ToString()}
                    };
                }
            }
            return null;
        }

        private string MD5(string password)
        {
            byte[] textBytes = Encoding.Default.GetBytes(password);
            try
            {
                MD5CryptoServiceProvider cryptHandler;
                cryptHandler = new MD5CryptoServiceProvider();
                byte[] hash = cryptHandler.ComputeHash(textBytes);
                string ret = "";
                foreach (byte a in hash)
                {
                    if (a < 16)
                        ret += "0" + a.ToString("x");
                    else
                        ret += a.ToString("x");
                }
                return ret;
            }
            catch
            {
                throw;
            }
        }
    }
}