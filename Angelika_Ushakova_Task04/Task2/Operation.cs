using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class Operation
    {
        static HashSet<char> strChar = new HashSet<char>();

        public static HashSet<char> GetFillSet(string str)
        {
            foreach (char c in str)
            {
                strChar.Add(c);
            }
            return strChar;
        }
        public static string GetReplaceStr(string str, string str1)
        {
            int lengthstr1 = str.Length - 1;

            for (int i = 0; i < lengthstr1; i++)
            {
                if (GetFillSet(str1).Contains(str[i]))
                {
                    str = str.Replace($"{str[i]}", $"{str[i]}{str[i]}");
                    ++i;
                }
            }
            return str;
        }
    }
}
