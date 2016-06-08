using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.UOW
{
    using Castle.Core;
    using EntityClasses.Person;
    using EntityClasses.Production;
    using Repository.DI;
    using Repository.Main;

    [Interceptor(typeof(CustomInterceptor))]
    public class Class1
    {
        private IRepository<Product> _rep;

        //public Class1(IRepository<Product> repository)
        //{
        //    _rep = repository;
        //}

        public void GetTest()
        { 
            var test1 = new RepositoryFactory<Contact>().GetRepository().GetAll(); 

             
        }
    }
}
