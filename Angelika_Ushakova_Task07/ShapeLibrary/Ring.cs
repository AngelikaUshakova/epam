using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
   public class Ring : Round
    {
        private double radius2;

        public Ring(Point point, double radius, double radius1) : base(point, radius1)
        {
            radius2 = radius;
            if (radius1 == radius2)
            {
                throw new ArgumentException("Радиусы не должны совпадать.");
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Рисуем кольцо с радиусами: {radius},{radius2} и координатами  центра: ({point.X}, {point.Y})");
        }
    }
}
