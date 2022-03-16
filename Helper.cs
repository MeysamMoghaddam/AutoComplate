using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ma2AutoComplate
{
    public static class Helper
    {
        public static ExpandoObject CreateExpandoFromObject(this object source)
        {
            var result = new ExpandoObject();
            IDictionary<string, object> dictionary = result;
            foreach (var property in source
                .GetType()
                .GetProperties()
                .Where(p => p.CanRead && p.GetMethod.IsPublic))
            {
                dictionary[property.Name] = property.GetValue(source, null);
            }
            return result;
        }
    }
}
