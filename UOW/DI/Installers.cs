namespace AdventureWorks.UOW.DI
{
    using Castle.MicroKernel.Registration;
    using Person;

    public class Installers: IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
             //.Register(Component.For<IRepository<AwbuildVersion>, IEditableRepository<AwbuildVersion>, IReadWriteRepository<AwbuildVersion>>().ImplementedBy<AwbuildVersionRepository<AwbuildVersion>>().LifestyleTransient())

            container
                .Register(Component.For<IAuthenticationUow>().ImplementedBy<AuthenticationUOW>().LifestyleTransient())
                .Register();
        }
    }
}
