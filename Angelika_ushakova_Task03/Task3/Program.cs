using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03Library;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N1 = 5;
            int[] arr = new int[N1];

            FillOutArr.RandomFill(arr);
            Console.WriteLine("Исходный массив:");
            FillOutArr.OutArr(arr);

            Console.WriteLine($"\nСумма всех неотрицательных чисел: { Operation.SumUp(arr)}");

            Console.ReadKey();
        }
    }
}
