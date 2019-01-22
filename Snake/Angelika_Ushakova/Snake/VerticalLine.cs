using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDawn, int x, char symbol)
        {
            pointList = new List<Point>();
            for (int y = yUp; y <= yDawn; y++)
            {
                Point p = new Point(x, y, symbol);

                pointList.Add(p);
            }

        }
    }
}
