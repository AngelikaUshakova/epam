using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Ring : Round
    {
        protected double radius2;

        public Ring(Coordinates center, double radius, double radius2) : base(center, radius)
        {
            Radiu2 = radius2;
        }

        public double Radiu2
        {
            get => radius2;
            set
            {
                if ((value <= 0) || (value == Radius))
                {
                    throw new Exception("Неверное значение внутреннего радиуса");
                }

                radius2 = value;
            }
        }

        public double AreaRing
        {
            get
            {
                return Math.Abs(AreaCircle - Math.PI * radius2 * radius2);
            }
        }

        public double LengthRing
        {
            get
            {
                return LengthCircle + 2 * Math.PI * radius2;
            }
        }
    }
}
