using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();

            string patternWord = @"\w+";

            int sum = 0;

            MatchCollection matches = Regex.Matches(str, patternWord);
            foreach(Match s in matches)
            {
                sum += s.Length ;
            }

            Console.WriteLine($"Строка: {str}");
            Console.WriteLine($"Средняя длина слова: {sum / matches.Count}");

            Console.ReadKey();
        }
    }
}
