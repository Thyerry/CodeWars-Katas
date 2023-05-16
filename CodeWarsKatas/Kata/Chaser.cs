using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Kata
{
    /**
     * https://www.codewars.com/kata/628df6b29070907ecb3c2d83
     */

    public class Chaser
    {
        public static char RUN_REST = 'R';
        public static char SPRINT = 'S';
        public static int Run(int s, int t)
        {
            if (t == 0) return 0;
            int b = (t + 1) * s;
            for (int i = 1; 2 * i < t && 3 * i < s; ++i)
            {
                b += s - 3 * i;
            }
            return b;
        }
    }
}
