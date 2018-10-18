using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class RandomValue
    {
        static Random random = new Random();

        public static Point RandomPoint()
        {
            Point point = new Point
            {
                X = random.Next(-100, 100),
                Y = random.Next(-100, 100)
            };

            return point;
        }

        public static double RandomRadius()
        {
            return random.Next(1,100);
        }
    }
}
