using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Kata
{
    public static class CubeSliced
    {
        public static int Run(int input)
        {
            if(input == 0) return 1;
            return (int) (Math.Pow(input+1, 3) - Math.Pow(input-1, 3));
        }
    }
}
