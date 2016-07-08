namespace TestDataFromDBToXML
{
    using AdventureWorks.Utils;
    using AdventureWorksAPIPasswordRestarter;
    using Autofac;
    using NHibernate;
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(Assembly.GetEntryAssembly());
            var container = builder.Build();


            int objectId = 1;
            string @namespace = "AdventureWorks.EntityClasses";
            var types = (from t in Assembly.GetExecutingAssembly().GetTypes()
                         where t.IsClass && t.Namespace.StartsWith(@namespace)
                         select t);

            foreach (var typeItem in types)
            {
                var idColumnName = typeItem.GetProperties().Where(item => item.Name.Contains("Id"))
                                                           .Select(item => item.Name)
                                                           .Where(item => item.Contains(typeItem.Name))
                                                           .FirstOrDefault();
                if (idColumnName != null)
                {
                    using (ISession session = SessionManager.OpenSession())
                    {
                        // T Get[T](Object) - method placement in the list
                        int genericMethodPlaceInTheMethodsList = 122;
                        MethodInfo method = session.GetType()
                                                   .GetMethods()[genericMethodPlaceInTheMethodsList]
                                                   .MakeGenericMethod(typeItem);

                        dynamic dbResult;
                        if (((System.Reflection.MemberInfo)(typeItem.GetProperty(idColumnName).PropertyType)).Name.Equals("Int32"))
                        {
                            dbResult = method.Invoke(session, new object[] { 1 });
                        }
                        else
                        {
                            Int16 idObject = 1;
                            dbResult = method.Invoke(session, new object[] { idObject });
                        }


                        if (dbResult != null)
                        {
                            String category = typeItem.Namespace.Split('.').Last();
                            String basePath = Path.GetFullPath(Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\..\..\..\..\Repository.Test\TestData\"));
                            String dataPath = String.Format("{0}\\{1}", category, typeItem.Name);
                            String directory = String.Format("{0}\\{1}", basePath, category);
                            String path = String.Format("{0}{1}.xml", basePath, dataPath);

                            if (!Directory.Exists(directory))
                            {
                                Directory.CreateDirectory(directory);
                            }


                            var xmlmanagerType = typeof(XMLManager<>)
                                                .MakeGenericType(dbResult.GetType());
                            var instanceOfXMLManager = Activator.CreateInstance(xmlmanagerType);
                            MethodInfo serializeMethodFromXMLManager = xmlmanagerType.GetMethod("SerializeAndStripFromToPlainTypes");
                            serializeMethodFromXMLManager.Invoke(instanceOfXMLManager, new object[] { dbResult, path });
                        }
                    }
                }
            }
        }
    }
}
