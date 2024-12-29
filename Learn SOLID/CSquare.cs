using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_SOLID
{
    internal class CSquare : I2DShape
    {
        private double side { get; set; }
        public CSquare(double side) { this.side = side; }
        public double CalculateArea()
        {
            return side * side;
        }
    }
}
