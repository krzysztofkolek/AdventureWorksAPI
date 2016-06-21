namespace AdventureWorks.UOW.Model.Base
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public abstract class BaseResultViewModel
    {
        public void PrepareForView()
        {
            foreach (PropertyInfo item in GetType().GetProperties())
            {
                if ((((item.PropertyType.UnderlyingSystemType).BaseType)).Name == typeof (BaseResultViewModel).Name)
                {
                    PrepareForView(item.GetValue(this),
                        (item.PropertyType.UnderlyingSystemType).GetProperties()
                            .Where(
                                x =>
                                    x.PropertyType.FullName.Equals("System.String") ||
                                    x.PropertyType.FullName.StartsWith("AdventureWorks")));
                }
                else
                {
                    if ("System.String".Equals(((item)).PropertyType.FullName))
                    {
                        if (item.GetType().GetProperty(item.Name) == null)
                        {
                            item.SetValue(this, string.Empty, null);
                        }
                    }
                }
            }
        }

        private void PrepareForView(dynamic obj, IEnumerable<PropertyInfo> info)
        {
            foreach (PropertyInfo item in info)
            {
                if (((item)).PropertyType.FullName.Equals("System.String"))
                {
                    if (item.GetType().GetProperty(item.Name) == null)
                    {
                        item.SetValue(obj, string.Empty, null);
                    }
                }

                if ((((item.PropertyType.UnderlyingSystemType).BaseType)).Name == typeof (BaseResultViewModel).Name)
                {
                    PrepareForView(obj.GetType().GetProperty(item.Name).GetValue(obj, null),
                        (item.PropertyType.UnderlyingSystemType).GetProperties()
                            .Where(
                                x =>
                                    x.PropertyType.FullName.Equals("System.String") ||
                                    x.PropertyType.FullName.StartsWith("AdventureWorks")));
                }
            }
        }
    }
}