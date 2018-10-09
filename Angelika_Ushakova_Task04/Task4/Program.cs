using System;
using System.Diagnostics;
using System.Text;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int N = 100; N <= 10000; N *= 10)
            {
                Console.WriteLine($"N = {N}");
                Console.WriteLine($"Скорость работы String: \t{CalculateConcatenationTime(N)}");
                Console.WriteLine($"Скорость работы StringBuilder:\t{CalculateStringBuilder(N)} ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static double CalculateConcatenationTime(int N)
        {
            Stopwatch timer = new Stopwatch();
            string str = "";

            timer.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            timer.Stop();

            return timer.Elapsed.TotalMilliseconds;
        }

        private static double CalculateStringBuilder(int N)
        {
            Stopwatch timer = new Stopwatch();
            StringBuilder sb = new StringBuilder();

            timer.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            timer.Stop();

            return timer.Elapsed.TotalMilliseconds;
        }

    }
}
