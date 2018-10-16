using System;

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
            Console.WriteLine("\nВведите значение второго радиуса:");
            double radius2 = GetValue();

            Ring ring = new Ring(center, radius, radius2);

            Console.WriteLine($"\nДлина окружности: {ring.LengthCircle:0.0000} | " +
                              $"Площадь круга: {ring.AreaCircle:0.0000}" +
                              $"\nДлина кольца: {ring.LengthRing:0.0000} | " +
                              $"Площадь кольца: {ring.AreaRing:0.0000}");

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

