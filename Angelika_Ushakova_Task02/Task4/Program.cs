using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
         
            for (int i = 1; i < n+1; i++)
            {
                int count = n-1;
                Console.WriteLine(new string(' ', count) + new string('*', 1));
                for (int j = 3; j < i * 2; j += 2)
                {
                    Console.WriteLine(new string(' ', --count) + new string('*', j));
                }
            }
            Console.ReadKey();
        }
    }
}
