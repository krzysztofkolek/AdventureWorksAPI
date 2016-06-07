namespace AdventureWorks.Repository.Main
{
    using Castle.Windsor;
    using Castle.Windsor.Installer;

    public class RepositoryFactory<T>
        where T: class, new()
    {
        private IWindsorContainer _container;

        public RepositoryFactory()
        {
            _container = new WindsorContainer();
            _container.Install(FromAssembly.This());
        }

        public IRepository<T> GetRepository()
        {
            return _container.Resolve<IRepository<T>>();
        }

        public IEditableRepository<T> GetEditableRepository()
        {
            return _container.Resolve<IEditableRepository<T>>();
        }
        public IReadWriteRepository<T> GetReadWriteRepository()
        {
            return _container.Resolve<IReadWriteRepository<T>>();
        }
    }
}
