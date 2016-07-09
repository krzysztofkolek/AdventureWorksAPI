namespace AdventureWorks.Utils
{

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
    }
}
