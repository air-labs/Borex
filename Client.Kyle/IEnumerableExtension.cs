using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Kyle
{
    public static class IEnumerableExtension
    {
        public static Tuple<T, T> GetFirstAndLast<T>(this IEnumerable<T> enumerable)
        {
            bool isFirst = true;
            T first = default(T);
            T last = default(T);
            foreach (var e in enumerable)
            {
                if (isFirst) { first = e; isFirst = false; }
                last = e;
            }
            return Tuple.Create(first, last);
        }
    }
}
