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
         
            MyString a = new MyString(Console.ReadLine());
            MyString b = new MyString(Console.ReadLine());

            Console.WriteLine($"{a + b}");
            Console.WriteLine($"{a - b}");
            Console.WriteLine($"{a == b}");

            Console.ReadKey();
        }
    }
}
