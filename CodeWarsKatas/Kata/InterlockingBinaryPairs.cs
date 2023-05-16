using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Kata
{
    public class InterlockingBinaryPairs
    {
        public static bool Run(ulong a, ulong b)
        {
            var binaryA = Convert.ToString((int)a, 2).Reverse().ToArray();
            var binaryB = Convert.ToString((int)b, 2).Reverse().ToArray();

            int lenght = binaryA.Count() < binaryB.Count() ? binaryA.Count() : binaryB.Count();
            for(int i = 0; i < lenght; i++) 
            {
                if (binaryA[i] == '1' && binaryB[i] == '1')
                    return false;
            }
            return true;
        }

        public static bool Alternative(ulong a, ulong b)
        {
            return (a & b) == 0;
        }
    }
}
