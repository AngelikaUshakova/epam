using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class GeometricProgression : ISeries
    {
        double start, denominator;
        int currentIndex;

        public GeometricProgression(double start, double denominator)
        {
            this.start = start;
            this.denominator = denominator;
            this.currentIndex = 0;
        }

        public double GetCurrent()
        {
            return start * Math.Pow(denominator,currentIndex);
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 0;
        }

    }
}
