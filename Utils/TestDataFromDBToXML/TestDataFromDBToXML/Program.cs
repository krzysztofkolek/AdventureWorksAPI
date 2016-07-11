namespace TestDataFromDBToXML
{
    using AdventureWorks.Utils;
    using AdventureWorksAPIPasswordRestarter;
    using NHibernate;
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    class Program
    {
        static void Main(string[] args)
        {
            PropertiesFiller filler = new PropertiesFiller();
            var modelsFromRepositoryTestMOdels = Assembly.LoadFile(Directory.GetCurrentDirectory() + "/AdventureWorks.Repository.Test.Model.dll");

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
                        var idTypeInfo = ((System.Reflection.MemberInfo)(typeItem.GetProperty(idColumnName).PropertyType)).Name;
                        if (idTypeInfo.Equals("Int32"))
                        {
                            dbResult = method.Invoke(session, new object[] { 1 });
                        }
                        else if (idTypeInfo.Equals("Byte"))
                        {
                            Byte idByte = 1;
                            dbResult = method.Invoke(session, new object[] { idByte });
                        }
                        else if (idTypeInfo.Equals("String"))
                        {
                            String idString = "";
                            dbResult = method.Invoke(session, new object[] { idString });
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

                            var modelFromAdventurworksRepositoryModels = modelsFromRepositoryTestMOdels.DefinedTypes
                                                                          .Where(item => item.Name.Equals(typeItem.Name))
                                                                          .First();

                            var xmlmanagerType = typeof(XMLManager<>)
                                                .MakeGenericType(modelFromAdventurworksRepositoryModels);
                            var instanceOfXMLManager = Activator.CreateInstance(xmlmanagerType);

                            var resultForXML = filler.CreateNewObject(dbResult, Activator.CreateInstance(modelFromAdventurworksRepositoryModels));

                            //MethodInfo serializeMethodFromXMLManager = xmlmanagerType.GetMethod("Serialize");
                            //serializeMethodFromXMLManager.Invoke(instanceOfXMLManager, new object[] { resultForXML, path });



                            var setset = filler.DeserializeFromXMLModelToDomainModel(resultForXML, dbResult);

                        }
                    }
                }
            }
        }
    }
}
