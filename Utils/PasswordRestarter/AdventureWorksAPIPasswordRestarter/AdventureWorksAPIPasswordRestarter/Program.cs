namespace AdventureWorksAPIPasswordRestarter
{
    using NHibernate;
    using NHibernate.Linq;
    using System;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            using (ISession session = SessionManager.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    foreach (var entity in session.Query<AdventureWorks.EntityClasses.Person.Contact>().AsQueryable().ToList())
                    {
                        try
                        {
                            entity.PasswordHash = MD5(string.Format("{0}{1}{2}", entity.EmailAddress, MD5(entity.EmailAddress), entity.PasswordSalt)) + "=";

                            session.SaveOrUpdate(entity);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                        }
                    }

                    transaction.Commit();
                }
            }
        }

        private static string MD5(string password)
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
