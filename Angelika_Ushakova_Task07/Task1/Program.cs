using ShapeLibrary;
using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 5;
            Shape[] shape = FillArr(N);
            DrawShape(shape);
        }

        private static void DrawShape(Shape[] shape)
        {
            for (int i = 0; i < shape.Length; i++)
            {
                shape[i].Draw(iprinter);
            }
            Console.ReadKey();
        }

        private static Shape[] FillArr(int N)
        {
            Shape[] shape = new Shape[N];
            Random rand = new Random();

            for (int i = 0; i < shape.Length; i++)
            {
                switch (rand.Next(5))
                {
                    case 0:
                        {
                            shape[i] = new Line(RandomValue.RandomPoint(), RandomValue.RandomPoint());
                            break;
                        }
                    case 1:
                        {
                            shape[i] = new Circle(RandomValue.RandomPoint(), RandomValue.RandomRadius());
                            break;
                        }
                    case 2:
                        {
                            shape[i] = new Rectangle(RandomValue.RandomPoint(), RandomValue.RandomPoint());
                            break;
                        }
                    case 3:
                        {
                            shape[i] = new Round(RandomValue.RandomPoint(), RandomValue.RandomRadius());
                            break;
                        }
                    case 4:
                        {
                            shape[i] = new Ring(RandomValue.RandomPoint(), RandomValue.RandomRadius(), RandomValue.RandomRadius());
                            break;
                        }
                }
            }

            return shape;
        }
    }
}
