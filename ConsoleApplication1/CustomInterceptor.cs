namespace AdventureWorks.Repository.DI
{
    using System;
    using System.Diagnostics;
    using Castle.DynamicProxy;

    public class CustomInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("In");
            invocation.Proceed();
            Console.WriteLine("Out");
        }
    }
}
