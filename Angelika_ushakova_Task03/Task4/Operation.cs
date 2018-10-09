﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Operation
    {
        public static int GetSumUp(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
