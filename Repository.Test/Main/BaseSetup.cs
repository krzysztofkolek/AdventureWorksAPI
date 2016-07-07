namespace AdventureWorks.Repository.Test.Main
{
    using NUnit.Framework;
    using System.Diagnostics;

    [SetUpFixture]
    public class BaseSetup
    {
        [SetUp]
        public void Setup()
        {
            Trace.WriteLine("It works... (Setup)");
        }
        [TearDown]
        public void Teardown()
        {
            Trace.WriteLine("It works... (Teardown)");
        }

        /// <summary>
        /// Removes and setsup a database from a bak file.
        /// </summary>
        private void SetupDatabase()
        {

        }
    }
}
