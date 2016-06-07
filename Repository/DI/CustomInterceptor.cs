namespace AdventureWorks.Repository.DI
{
    using System.Diagnostics;
    using Castle.DynamicProxy;

    public class CustomInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();

        }
    }
}
