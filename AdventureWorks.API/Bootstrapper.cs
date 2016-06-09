﻿namespace AdventureWorks.API
{
    using Nancy;
    using Nancy.Authentication.Token;
    using Nancy.Bootstrapper;
    using Nancy.TinyIoc;
    using Shared.Auth;
    using UOW.Person;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {
            TokenAuthentication.Enable(pipelines, new TokenAuthenticationConfiguration(container.Resolve<ITokenizer>()));
            
            container.AutoRegister();
        }
    }
}
