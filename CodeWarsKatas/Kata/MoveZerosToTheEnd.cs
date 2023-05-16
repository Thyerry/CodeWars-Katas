using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Kata
{
    public class MoveZerosToTheEnd
    {
        public static int[] Run(int[] arr)
        {
            var aux = arr.Where(x => x > 0).ToArray();
            int[] res = new int[arr.Count()];
            for(int i = 0; i < aux.Count(); i++)
            {
                res[i] = aux[i];
            }
            return res;
        }
    }
}
