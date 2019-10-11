using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace technology_tp1
{
    public static class EnumExtension
    {
        public static IEnumerable<T> GetValues<T>()
        {
            foreach (var value in Enum.GetValues(typeof(T)))
            {
                yield return (T)value;
            }
        }
    }
}
