namespace AdventureWorks.Repository.DI
{
    using Castle.MicroKernel.Registration; 

    public class Installers : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {

            container.Register(Component.For<CustomInterceptor>()
                               .LifestyleTransient());
                     
        }
    }
}
