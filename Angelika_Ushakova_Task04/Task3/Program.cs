using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Выберите культуры:\n");
                Console.WriteLine("1.\"ru\" vs \"en\"\n");
                Console.WriteLine("2.\"en\" vs \"invariant\"\n");
                Console.WriteLine("3.\"ru\" vs \"invariant\"\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        Operation.OutInfoCulture(new CultureInfo("ru"), new CultureInfo("en")); break;
                    case "2":
                        Operation.OutInfoCulture(new CultureInfo("en"), new CultureInfo(string.Empty)); break;
                    case "3":
                        Operation.OutInfoCulture(new CultureInfo("ru"), new CultureInfo(string.Empty)); break;
                    default:
                        Console.WriteLine("Неверное значение. Повторите попытку."); break;
                }

                Console.WriteLine("\nВведите y для повтора.");
            } while (Console.ReadLine() == "y");
        }
    }
}
