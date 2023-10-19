using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounce
{
    internal static class BallBouncer
    {
        public static int Bounce(double h, double bounce, double window)
        {
            if (h < 0 || bounce <= 0 || bounce >=1 || window >= h)
                return -1;
            var res = 0;
            var ballHeight = h;
            while (ballHeight > window)
            {
                res++;
                ballHeight *= bounce;
                if (ballHeight > window) res++;
            }
            return res;
        }
    }
}
