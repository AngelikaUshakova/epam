using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку:");
            string str1 = Console.ReadLine();
            Console.WriteLine("\nВведите вторую строку:");
            string str2 = Console.ReadLine();

            Console.WriteLine($"Новая строка: {Operation.GetReplaceStr(str1.ToLower(), str2.ToLower())}");
            Console.ReadKey();
        }
    }
}
