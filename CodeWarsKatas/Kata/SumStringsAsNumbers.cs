using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Kata
{
    public class SumStringsAsNumbers
    {
        public static string Run(string a, string b)
        {
            if (UInt64.TryParse(a, out ulong oa) && UInt64.TryParse(b, out ulong ob))
            {
                return (oa + ob).ToString();
            }
            string.IsNullOrEmpty(a);
            int minLenght = Math.Min(a.Length, b.Length);
            int lengthDiff = Math.Abs(a.Length - b.Length);
            var arr = a.Reverse().ToArray();
            var brr = b.Reverse().ToArray();
            string result = string.Empty;
            bool greaterThanNine = false;
            for (int i = 0; i < minLenght; i++)
            {
                int aux = 0;
                if (greaterThanNine)
                    aux = Abs(arr[i], brr[i]) + 1;
                else
                    aux = Abs(arr[i], brr[i]);
                if (aux > 9)
                {
                    greaterThanNine = true;
                    result = aux.ToString()[1] + result;
                }
                else
                {
                    greaterThanNine = false;
                    result = aux.ToString()[0] + result;
                }
            }
            var remainer = new char[lengthDiff];
            if (lengthDiff > 0)
            {
                if (a.Length > b.Length)
                    remainer = a.Substring(0, lengthDiff).ToCharArray();
                else
                    remainer = b.Substring(0, lengthDiff).ToCharArray();
            }
            if(!greaterThanNine)
            {
                result = String.Join("", remainer) + result;
            }
            while (greaterThanNine)
            {
                if(lengthDiff == 0)
                {
                    result = '1' + String.Join("", remainer) + result;
                    greaterThanNine = false;
                }
                else
                {
                    int aux = (int)Char.GetNumericValue(remainer[lengthDiff - 1]) + 1;
                    if (aux <= 9)
                    {
                        remainer[lengthDiff - 1] = aux.ToString()[0];
                        result = String.Join("", remainer) + result;
                        greaterThanNine = false;
                    }
                    else
                    {
                        remainer[lengthDiff - 1] = aux.ToString()[1];
                    }
                }
                lengthDiff--;
            }
            return result;
        }

        public static int Abs(char a, char b)
        {
            return (int)Math.Abs(Char.GetNumericValue(a) + Char.GetNumericValue(b));
        }

        public static string Alternative(string a, string b) => (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
    }
}
