using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Operation
    {
        public static int[,,] ReplaceArr(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = arr[i, j, k] > 0 ? 0 : arr[i, j, k];
                    }
                }
            }
            return arr;
        }
    }
}
