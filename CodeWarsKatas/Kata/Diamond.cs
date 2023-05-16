using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Kata
{
    public class Diamond
    {
        public static string Run(int n)
        {
            if (n < 1 || n % 2 == 0) 
                return null;
            var result = string.Empty;

            int halfString = (int) Math.Floor((decimal)n / 2);
            for (int i = 0; halfString > i; i++)
            {
                result += new string(' ', halfString - i)
                    + new string('*', i)
                    + '*'
                    + new string('*', i)
                    + "\n"; ;
            };
            for (int i = halfString; i >= 0; i--)
            {
                result += new string(' ', halfString - i)
                    + new string('*', i)
                    + '*'
                    + new string('*', i)
                    + "\n"; ;
            }
            return result;
        }

        public static string print(int n)
        {
            if (n < 0 || n % 2 == 0) return null;

            int middle = n / 2;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(' ', Math.Abs(middle - i));
                sb.Append('*', n - Math.Abs(middle - i) * 2);
                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}
