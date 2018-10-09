using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
   public static class Operation
    {
        public static int GetSumUp(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] >= 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
    }
}
