using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Ring : Round
    {
        protected double interiorRadius;

        public Ring(Coordinates center, double radius, double interiorRadius) : base(center, radius)
        {
            InteriorRadius = interiorRadius;
        }

        public double InteriorRadius
        {
            get => interiorRadius;
            set
            {
                if ((value <= 0) || (value > Radius))
                {
                    throw new Exception("Неверное значение внутреннего радиуса");
                }

                interiorRadius = value;
            }
        }

        public double AreaRing
        {
            get
            {
                return AreaCircle - Math.PI * InteriorRadius * InteriorRadius;
            }
        }

        public double LengthRing
        {
            get
            {
                return LengthCircle + 2 * Math.PI * InteriorRadius;
            }
        }
    }
}
