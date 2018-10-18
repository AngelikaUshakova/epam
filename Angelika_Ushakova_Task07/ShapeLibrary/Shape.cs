using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public abstract class Shape
    {
        public abstract void Draw();
    }
}
