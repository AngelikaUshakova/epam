using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Rectangle : Shape
    {
        private Point point1;
        private Point point2;

        public Rectangle(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public override void Draw()
        {
            Console.WriteLine($"Рисуем прямоугольник с координатами: ({point1.X}, {point1.Y});({point2.X}, {point2.Y})");
        }
    }
}
