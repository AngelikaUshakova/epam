using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public delegate int Operation(string str1, string str2);
        static void Main(string[] args)
        {
            string[] strings = {"Привет","Как","Дела", "Завтрб", "Завтра" };

            SortStringArr(strings, CompareString);
            Console.WriteLine($"{string.Join("\n", strings)}");
            Console.ReadKey();
        }

        static void SortStringArr(string[] strings, Operation action)
        {
            string tmp;
            for (int i = 0; i < strings.Length-1; i++)
            {
                for (int j = i + 1; j < strings.Length; j++)
                {
                    if (action(strings[i], strings[j]) > 0)
                    {
                        tmp = strings[i];
                        strings[i] = strings[j];
                        strings[j] = tmp;
                    }
                }
            }
        }

        static int CompareString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return -1;
            }

            if (str1.Length > str2.Length)
            {
                return 1;
            }

            return str1.CompareTo(str2);
        }
    }
}
