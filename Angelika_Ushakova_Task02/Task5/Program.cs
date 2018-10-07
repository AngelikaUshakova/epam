using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Divider1 = 3;
            const int Divider2 = 5;
            const int Divider3 = Divider1 * Divider2;
            const int MaxValue = 999;
           

            double amount = (Divider1 + (MaxValue / Divider1) * Divider1) / 2d * (MaxValue / Divider1)
                + (Divider2 + (MaxValue / Divider2) * Divider2) / 2d * (MaxValue / Divider2)
                - (Divider3 + (MaxValue / Divider3) * Divider3) / 2d * (MaxValue / Divider3);

            Console.WriteLine($"Сумма всех чисел меньше 1000, кратных 3, или 5: {amount}");
            Console.ReadKey();
        }
    }
}
