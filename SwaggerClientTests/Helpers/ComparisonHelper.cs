using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using KellermanSoftware.CompareNetObjects;

namespace PIWebAPICSharpClientTests.Helpers
{
    public static class ComparisonHelper
    {
        //http://stackoverflow.com/questions/506096/comparing-object-properties-in-c-sharp
        //Not a deep compare but will do for now
        public static bool PublicInstancePropertiesEqual<T>(this T self, T to, params string[] ignore) where T : class
        {
            if (self != null && to != null)
            {
                var type = typeof(T);
                var ignoreList = new List<string>(ignore);
                var unequalProperties =
                    from pi in type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    where !ignoreList.Contains(pi.Name)
                    let selfValue = type.GetProperty(pi.Name).GetValue(self, null)
                    let toValue = type.GetProperty(pi.Name).GetValue(to, null)
                    where selfValue != toValue && (selfValue == null || !selfValue.Equals(toValue))
                    select new { Self = selfValue, To = toValue };
                return !unequalProperties.Any();
            }
            return self == to;
        }

        public static bool DeepCompare(object self, object to)
        {
            CompareLogic compareLogic = new CompareLogic();
            compareLogic.Config.MaxDifferences = 100;

            ComparisonResult result = compareLogic.Compare(self, to);
            if (!result.AreEqual)
                Console.WriteLine(result.DifferencesString);
            return result.AreEqual;
        }

        public static bool DeepCompareRecursive<T>(this T self, T to) where T : class
        {
            if (self != null && to != null)
            {
                var type = typeof(T);
                PropertyInfo[] props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (var prop in props)
                {
                    if (!prop.PropertyType.IsValueType)
                    {
                        var selfRef = type.GetProperty(prop.Name).GetValue(self, null);
                        var toRef = type.GetProperty(prop.Name).GetValue(to, null);

                        bool result = DeepCompareRecursive(selfRef, toRef);
                        if (!result) return false;
                    }
                    else
                    {
                        var selfVal = type.GetProperty(prop.Name).GetValue(self, null);
                        var toVal = type.GetProperty(prop.Name).GetValue(to, null);
                        if (selfVal != toVal)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else if (self == null ^ to == null)
            {
                return false;
            }
            else //both are null
            {
                return true;
            }

        }
    }
}
