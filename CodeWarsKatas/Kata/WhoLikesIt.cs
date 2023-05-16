using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Kata
{
    public static class WhoLikesIt
    {
        public static string Run(string[] name)
        {

            if (name == null || name.Length == 0)
                return "no one likes this";

            if (name.Length == 1)
                return $"{name[0]} likes this";

            if (name.Length == 2)
                return $"{name[0]} and {name[1]} like this";

            if (name.Length == 3)
                return $"{name[0]}, {name[1]} and {name[2]} like this";

            return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
        }

        public static string RunOtherSolution(string[] name) {
            string[] pattern = 
            { 
                "no one likes this",
                "{0} likes this",
                "{0} and {1} like this",
                "{0}, {1} and {2} like this",
                "{0}, {1} and {2} others like this"
            };

            return name.Length < 4 ? string.Format(pattern[name.Length], name) : string.Format(pattern[4], name[0], name[1], name.Length - 2);
        }
    }
}
