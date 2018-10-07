using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03Library;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 5;
            int[] arr = new int[N];

            FillOutArr.RandomFill(arr);
            Console.WriteLine("Исходный массив:");
            FillOutArr.OutArr(arr);

            Operation.FindMaxMin(arr);

            Operation.SortArr(arr);
            Console.WriteLine("\nОтсортированный массив:");
            FillOutArr. OutArr(arr);

            Console.ReadKey();
        }
    }
}
