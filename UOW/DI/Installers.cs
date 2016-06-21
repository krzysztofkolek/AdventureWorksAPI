namespace AdventureWorks.UOW.DI
{
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;
    using Castle.Windsor.Installer;
    using Person;

    public class Installers : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //.Register(Component.For<IRepository<AwbuildVersion>, IEditableRepository<AwbuildVersion>, IReadWriteRepository<AwbuildVersion>>().ImplementedBy<AwbuildVersionRepository<AwbuildVersion>>().LifestyleTransient())

            container
                .Register(Component.For<IAuthenticationUow>().ImplementedBy<AuthenticationUOW>().LifestyleTransient())
                .Install(FromAssembly.Containing(typeof (Installers)));
        }
    }
}