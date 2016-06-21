namespace AdventureWorks.UOW.Configuration
{
    public class Configuration
    {
        private static Configuration InstanceContainer { get; set; }

        public static Configuration Instance
        {
            get
            {
                if (InstanceContainer == null)
                {
                    InstanceContainer = new Configuration();
                }
                return InstanceContainer;
            }
        }

        public int PageSize
        {
            get { return 10; }
        }

        public static Configuration GetInstance()
        {
            return Instance;
        }
    }
}