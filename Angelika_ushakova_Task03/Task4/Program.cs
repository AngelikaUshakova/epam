using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03Library;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N1 = 2, N2=3;
            int[,] arr = new int[N1,N2];

            FillOutArr.RandomFill(arr);
            Console.WriteLine("Исходный массив:");
            FillOutArr.OutArr(arr);

            Console.WriteLine($"\nСумма всех элементов, стоящих на четной позиции: { Operation.GetSumUp(arr)}");

            Console.ReadKey();
        }
    }
}
