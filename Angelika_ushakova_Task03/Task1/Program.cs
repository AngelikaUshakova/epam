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

            int max = Operation.GetFindMax(arr);
            int min = Operation.GetFindMin(arr);
            Console.WriteLine($"\n\nМаксимальный элемент: {max} \nМинимальный элемент: {min}");

            Operation.SortArr(arr);
            Console.WriteLine("\nОтсортированный массив:");
            FillOutArr. OutArr(arr);

            Console.ReadKey();
        }
    }
}
