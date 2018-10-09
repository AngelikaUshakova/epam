using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string timePattern = @"(\W|^)(([01]?[0-9])|(2[0-3])):[0-5][0-9](\W|$)";
            string str = "2:23  3:61 Время19:24 21:31";

            Console.WriteLine($"Время в тексте присутствует {Regex.Matches(str, timePattern).Count} раз.");

            Console.ReadKey();
        }
    }
}
