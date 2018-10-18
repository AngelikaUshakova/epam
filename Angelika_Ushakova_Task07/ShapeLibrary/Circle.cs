using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Circle : Round
    {
        public Circle(Point point, double radius) : base(point, radius) { }

        public override void Draw()
        {
            Console.WriteLine($"Рисуем окружность с радиусом: {radius} и координатами  центра: ({point.X}, {point.Y})");
        }
    }
}
