using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите первую сторону прямоугольника:");
                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine("Введите вторую сторону прямоугольника:");
                    if (int.TryParse(Console.ReadLine(), out int b))
                    {
                        if (a <= 0 || b <= 0)
                        {
                            Console.WriteLine("Ошибка ввода, значения сторон должны быть больше 0,повторить ввод? Y/N");
                            if (Console.ReadKey().Key != ConsoleKey.Y)
                                continue; 
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"Площадь прямоугольника: {a * b}");
                            break;
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
