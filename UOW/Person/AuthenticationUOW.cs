
namespace AdventureWorks.UOW.Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EntityClasses.Person;
    using Model.Person;
    using Repository.dbo;

    public static class AuthenticationUOW
    {
        private static ContactRepository<Contact> _contactRepository = new ContactRepository<Contact>();
        
        public static AuthenticationUOWModel ValidateHashedPassword(string username, string password)
        {
            var dbUser = _contactRepository.SearchFor(x => x.EmailAddress == username).FirstOrDefault();
            if (dbUser != null)
            {
                string passwordGenerated = MD5(string.Format("{0}{1}{2}", username, password.Trim(), dbUser.PasswordSalt)) + "=";

                if (dbUser.PasswordHash.Equals(passwordGenerated))
                {
                    return new AuthenticationUOWModel()
                    {
                        UserName = username,
                        Claims = new List<String>() { "" }
                    };
                }
            }
            return null;
        }



        private static string MD5(string password)
        {
            byte[] textBytes = System.Text.Encoding.Default.GetBytes(password);
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider cryptHandler;
                cryptHandler = new System.Security.Cryptography.MD5CryptoServiceProvider();
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
