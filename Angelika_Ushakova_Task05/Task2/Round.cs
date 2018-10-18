using System;

namespace Task2
{
    public struct Coordinates
    {
        public Coordinates(double x, double y) : this()
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }
    }

    class Round
    {
        double radius;
        Coordinates center;

        public Round(Coordinates center, double radius)
        {
            this.center = center;
            Radius = radius;
        }

        public double LengthCircle
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }

        public double AreaCircle
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

        public double Radius
        {
            get => radius;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Неверное значение радиуса");
                }

                radius = value;
            }
        }
    }
}
