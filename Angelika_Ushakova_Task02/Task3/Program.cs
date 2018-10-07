using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int count = n - 1;
            Console.WriteLine(new string(' ', count) + new string('*', 1));
            for (int i = 3; i < n*2; i+=2)
            {
                Console.WriteLine(new string(' ', --count) + new string('*', i));
            }
            Console.ReadKey();
        }
    }
}
