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
            Sides b = new Sides(0,5,6);
            
            Triangle a = new Triangle(b);
            Console.WriteLine($"{a.Sides.A} | {a.Sides.B} | {a.Sides.C} | {a.Area:0.00} | {a.Perimeter:0.00}");

            Console.ReadKey();
        }
    }
}
