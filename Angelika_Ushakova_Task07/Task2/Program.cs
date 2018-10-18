using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ISeries progression = new GeometricProgression(3, 2);
            PrintSeries(progression);
            Console.ReadKey();
        }

        static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
    }
}
