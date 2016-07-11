namespace AdventureWorks.Utils
{
    using System.Linq;
    using System.Text.RegularExpressions;

    public class PropertiesFiller
    {
        public dynamic CreateNewObject(dynamic oldObject, dynamic newobject)
        {
            var props = oldObject.GetType().GetProperties();
            var declaratedTypesNewObject = ((System.Reflection.FieldInfo[])(((System.Reflection.TypeInfo)(newobject.GetType())).DeclaredFields));

            foreach (var item in declaratedTypesNewObject)
            {
                for (int i = 0; i < props.Length; i++)
                {
                    if (props[i].Name.Equals(item.Name))
                    {
                        var value = props[i].GetValue(oldObject, null);
                        item.SetValue(newobject, value);
                    }
                }
            }
            return newobject;
        }

        public object DeserializeFromXMLModelToDomainModel(object deserializedObject, object domainModelInstance)
        {
            var declaratedTypesNewObject = ((System.Reflection.FieldInfo[])(((System.Reflection.TypeInfo)(deserializedObject.GetType())).DeclaredFields));
            foreach (var item in declaratedTypesNewObject)
            {
                var itemName = item.Name;// Regex.Match(item.Name, @"\<(.*?)\>").Value.Replace("<", "").Replace(">", "");
                var setProperty = domainModelInstance.GetType()
                                                     .GetProperties()
                                                     //.Where(it => it.Name.Contains("set"))
                                                     .Where(it => it.Name.Contains(itemName))
                                                     .FirstOrDefault();

                if (setProperty != null)
                {
                    if(setProperty.CanWrite)
                    {
                        var value = item.GetValue(deserializedObject);
                        setProperty.SetValue(domainModelInstance, value);
                    }
                }
            }
            return declaratedTypesNewObject;
        }
    }
}
