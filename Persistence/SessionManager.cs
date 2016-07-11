namespace AdventureWorks
{
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using NHibernate;
    using System;
    using System.Configuration;

    /// <summary>
    ///     Small, simple session manager class which initializes NHibernate's session factory and loads the
    ///     configuration.
    /// </summary>
    public static class SessionManager
    {
        #region Class Member Declarations

        private static ISessionFactory _sessionFactory;

        #endregion

        /// <summary>Initializes the <see cref="SessionManager" /> class.</summary>
        static SessionManager()
        {
            try
            {
                _sessionFactory = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2005
                        .ConnectionString(c => c.FromConnectionStringWithKey("AdventureWorksConnectionString")))
                    .Mappings(m => m.FluentMappings.AddFromAssembly(typeof(SessionManager).Assembly))
                    .BuildSessionFactory();
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>Opens a new session on the existing session factory</summary>
        /// <returns>ready to use ISession instance</returns>
        /// <remarks>
        ///     Dispose this instance after you're done with the instance, so after lazy loading has occured. The returned
        ///     ISession instance is <b>not</b> thread safe.
        /// </remarks>
        public static ISession OpenSession()
        {
            if (_sessionFactory == null)
            {
                BuildSessionFactory();
            }
            return _sessionFactory.OpenSession();
        }

        public static void BuildSessionFactory()
        {
            try
            {
                _sessionFactory = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2005
                        .ConnectionString(@"Data Source=CYSPC\MSSQL2016;Initial Catalog=AdventureWorks;Integrated Security=True;TrustServerCertificate=False;TrustServerCertificate=False"))
                    .Mappings(m => m.FluentMappings.AddFromAssembly(typeof(SessionManager).Assembly))
                    .BuildSessionFactory();
            }
            catch (Exception ex)
            {
            }
        }

        #region Class Property Declarations

        /// <summary>Gets the session factory created from the initialized configuration. The returned factory is thread safe.</summary>
        public static ISessionFactory SessionFactory
        {
            get { return _sessionFactory; }
        }

        #endregion
    }
}