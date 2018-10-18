using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Round : Shape
    {
        protected Point point;
        protected double radius;

        public Round(Point point, double radius)
        {
            this.point = point;
            this.radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Рисуем круг с радиусом: {radius} и координатами  центра: ({point.X}, {point.Y})");
        }
    }
}
