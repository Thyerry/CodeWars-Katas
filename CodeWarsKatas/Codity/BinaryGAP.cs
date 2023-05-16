using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Codity
{
    public class BinaryGAP
    {
        public static int Run(int N)
        {
            string binary = Convert.ToString(N, 2);
            int result = 0;
            int currentGapCount = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    if (currentGapCount > 0)
                    {
                        result = currentGapCount > result ? currentGapCount : result;
                        currentGapCount = 0;
                    }
                }
                else
                    currentGapCount++;
            }
            Console.WriteLine(binary);
            return result;
        }

        public static int Alternative(int N)
        {
            string binary = Convert.ToString(N, 2);
            if(binary.Last() == '0')
            {
                var list = binary.Split('1').ToList();
                
                return list.Max().Length;
            }

            return binary.Split('1').Max().Length;
        }
    }
}
