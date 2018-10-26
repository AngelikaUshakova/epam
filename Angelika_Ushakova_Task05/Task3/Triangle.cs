using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public struct Sides
    {
        private double a;
        private double b;
        private double c;

        
        public Sides(double a, double b, double c) : this()
        {
            A = a;
            B = b;
            C = c;
        }

        public double A
        {
            get => a;
            set
            {
                CheckSide(value);
                a = value;
            }
        }

        public double B
        {
            get => b;
            set
            {
                CheckSide(value);
                b = value;
            }
        }
        public double C
        {
            get => c;
            set
            {
                CheckSide(value);
                c = value;
            }
        }

        private void CheckSide(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Неверное значение стороны(значение должно быть больше 0)");
            }
        }
    }
    class Triangle
    {
        private Sides sides;
        private double area;
        private double perimeter;

        public Triangle(Sides sides)
        {
            Sides = sides;
        }

        public Sides Sides
        {
            get => sides;
            set
            {
                CheckSides(value);
                sides = value;
            }
        }

        public double Area
        {
            get => area = GetAr();
            set => area = value;
        }
        public double Perimeter
        {
            get => perimeter = GetPerimetr();
            set => perimeter = value;
        }
       
        private void CheckSides(Sides value)
        {
            double a = value.A;
            double b = value.B;
            double c = value.C;

            if (((a + b) < c) || ((a + c) < b) || ((c + b) < a))
            {
                throw new ArgumentException("Некорректные значения сторон");
            }
        }

        private double GetPerimetr()
        {
            return sides.A + sides.B + sides.C;
        }

        public double GetAr()
        {
            double semiPerimetr = GetPerimetr()/2;
            return Math.Sqrt(semiPerimetr * (semiPerimetr - sides.A) * (semiPerimetr - sides.B) * (semiPerimetr - sides.C));
        }
    }
}
