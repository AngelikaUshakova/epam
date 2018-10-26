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
            Sides sides = new Sides(3,5,6);
            
            Triangle triangle = new Triangle(sides);
            Console.WriteLine($"{triangle.Sides.A} | {triangle.Sides.B} | {triangle.Sides.C}" +
                              $" | {triangle.Area:0.00} | {triangle.Perimeter:0.00}");

            Console.ReadKey();
        }
    }
}
