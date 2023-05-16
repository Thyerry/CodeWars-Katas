using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Kata
{
    public class RemoveParenheses
    {
        public static string Run(string s)
        {
            string result = string.Empty;
            int openParentheses = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ')')
                    openParentheses--;
                else if (s[i] == '(')
                    openParentheses++;
                else if (openParentheses == 0)
                    result += s[i];
            }
            return result;
        }
    }
}
