using DemoApplication;
using System;

namespace Task3
{
    class Program
    {
        static public void PrintList(IIndexable indexer, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (indexer[i] % 3 == 0)
                {
                    Console.WriteLine(indexer[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            double[] array = new double[] { 5, 3, 1,10, 6, 1, 9, 7, 12};
            List list = new List(array);
            PrintList(list, array.Length);

            ArithmeticalProgression progression = new ArithmeticalProgression(2, 4);
            PrintList(progression, 5);

            Console.ReadKey();
        }
    }
}
