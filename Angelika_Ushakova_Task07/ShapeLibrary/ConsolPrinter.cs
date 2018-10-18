using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    class ConsolPrinter : IPrinter
    {
        public void Print(int x, int y)
        {
            Console.WriteLine();
        }
    }
}
