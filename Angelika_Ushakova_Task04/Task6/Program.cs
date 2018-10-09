using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string sciencePattern = @"^[-+]?[0-9]\.[0-9]+[eE]-?[0-9]+$";
            string normalPattern = @"^[-+]?[0-9]+\.[0-9]+$";

            Console.Write("Введите число: ");
            string number = Console.ReadLine();

            if (Regex.IsMatch(number, normalPattern))
            {
                Console.WriteLine("Это число в обычной нотации");
            }
            else if (Regex.IsMatch(number, sciencePattern))
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else
            {
                Console.WriteLine("Это не число");
            }
            Console.ReadKey();
        }
    }
}
