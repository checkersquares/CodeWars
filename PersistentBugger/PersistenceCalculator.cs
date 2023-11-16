using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistentBugger
{
    public static class PersistenceCalculator
    {
        public static int GetPersistence(long n)
        {
            var res = 0;
            while (n.ToString().Length > 1)
            {
                n = MultiplyDigits(n);
                res++;
            }
            return res;
        }
        private static long MultiplyDigits(long n)
        {
            var res = 1;
            foreach (var digit in n.ToIntArray())
            {
                res *= digit;
            }
            return res;
        }
        private static int[] ToIntArray(this long n)
        {
            return n.ToString().Select(d => int.Parse(d.ToString())).ToArray();
        }
    }
}
