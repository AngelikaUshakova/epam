using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03Library;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N1 = 3, N2 = 2, N3 = 3 ;
            int[,,] arr = new int[N1, N2, N3];

            FillOutArr.RandomFill(arr);
            Console.WriteLine("Исходный массив:");
            FillOutArr.OutArr(arr);

            Operation.ReplaceArrOnZero(arr);
            Console.WriteLine("\nМассив после замены:");
            FillOutArr.OutArr(arr);

            Console.ReadKey();
        }
    }
}
