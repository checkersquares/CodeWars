using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    internal static class Multiples
    {
        public static int GetSumOfMultiplesOfThreeAndFive(int value)
        {
            if (value < 1) return 0;
            var res = 0;
            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    res += i;
            }
            return res;
        }
    }
}
