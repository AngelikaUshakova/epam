using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение первой координаты:");
            double x = GetValue();

            Console.WriteLine("\nВведите значение второй координаты:");
            double y = GetValue();

            Coordinates center = new Coordinates(x, y);

            Console.WriteLine("\nВведите значение радиуса:");
            double radius = GetValue();
            Round a = new Round(center, radius);

            Console.WriteLine($"\nДлина окружности: {a.LengthCircle:0.0000} | Площадь круга: {a.AreaCircle:0.0000}");

            Console.ReadKey();
        }

        private static double GetValue()
        {
            double val;
            if (double.TryParse(Console.ReadLine(), out val))
            {
                return val;
            }

            throw new Exception("Некорректное значение");
        }
    }
}
