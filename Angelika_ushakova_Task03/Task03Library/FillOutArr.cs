using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03Library
{
    public static class FillOutArr
    {
        static public int[] RandomFill(int[] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-100, 100);
            }
            return arr;
        }

        static public int[,] RandomFill(int[,] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(-100, 100);
                }
            }

            return arr;
        }

        static public int[,,] RandomFill(int[,,] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = r.Next(-100, 100);
                    }
                }
            }

            return arr;
        }

        static public void OutArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i],5} ");
            }
               
        }

        static public void OutArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j],5} ");
                }
                Console.WriteLine();
            }
               
        }

        static public void OutArr(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"Массив №{i}:");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write($"{arr[i, j, k],5}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
                
        }

    }
}
