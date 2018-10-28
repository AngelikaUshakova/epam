using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public delegate int Operation(string str1, string str2);

        public static event Action Complete;

        static void Main(string[] args)
        {
            string[] strings = new string[4000];
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = (strings.Length - i).ToString();
            }

            Complete += () => Console.WriteLine("Сортировка завершена");
            Thread threadSort = new Thread(() => SortStringArr(strings,CompareString));
            threadSort.Start();

            Console.ReadKey();
        }

        static void SortStringArr(string[] strings, Operation action)
        {
            string tmp;
            for (int i = 0; i < strings.Length - 1; i++)
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
            Complete?.Invoke();
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
