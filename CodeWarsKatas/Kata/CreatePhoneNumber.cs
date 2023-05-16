using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Kata
{
    public static class CreatePhoneNumber
    {
        public static string Run(int[] numbers)
        {
            if (numbers == null || numbers.Length != 10)
                throw new ArgumentException("Input not Valid!");

            string result = long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");

            return result;
        }
    }
}
