using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_SOLID
{
    internal class CRectangle : I2DShape
    {
        private double length { get; set; }
        private double breadth { get; set; }
        public CRectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public double CalculateArea()
        {
            return length * breadth;
        }
    }
}
