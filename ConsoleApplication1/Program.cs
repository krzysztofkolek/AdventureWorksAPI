using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    using System.Configuration;
    using System.Security.Cryptography;
    using AdventureWorks.Repository.DI;
    using AdventureWorks.UOW;
    using Castle.Core;

    [Interceptor(typeof (CustomInterceptor))]
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Class1 test = new Class1();
            //test.GetTest();

        }
    }
}