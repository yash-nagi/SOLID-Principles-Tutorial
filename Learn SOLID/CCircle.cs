using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_SOLID
{
    internal class CCircle : I2DShape
    {
        private double dRadius { get; set; }
        public CCircle(double radius)
        {
            dRadius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * dRadius * dRadius;
        }
    }
}
