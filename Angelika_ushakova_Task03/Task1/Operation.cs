using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
   static public class Operation
    {
        static public void FindMaxMin(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                min = arr[i] < min ? arr[i] : min;
                max = arr[i] > max ? arr[i] : max;
            }
            Console.WriteLine($"\n\nМаксимальный элемент: {max} \nМинимальный элемент: {min}");
        }

        static public int[] SortArr(int[] arr)
        {
            int swap;
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        swap = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swap;
                    }

            return arr;
        }
    }
}
