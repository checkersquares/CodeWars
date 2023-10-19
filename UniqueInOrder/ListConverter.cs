using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueInOrder
{
    public static class ListConverter
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            int i = -1;
            foreach (T item in iterable)
            {
                if (i < 0 || !item.Equals(iterable.ElementAt(i)))
                    yield return item;
                i++;
            }
        }
    }
}
