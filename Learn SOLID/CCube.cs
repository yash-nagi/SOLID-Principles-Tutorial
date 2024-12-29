using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_SOLID
{
    internal class CCube : I3DShape
    {
        private double side { get; set; }
        public CCube(double side)
        {
            this.side = side;
        }
        public double CalculateVolume()
        {
            return side * side * side;
        }
    }
}
