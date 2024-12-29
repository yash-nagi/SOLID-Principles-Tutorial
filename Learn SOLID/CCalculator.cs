using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_SOLID
{
    internal class CCalculator
    {
        public CCalculator() { }
        public static double GetArea(I2DShape shape)
        {
            return shape.CalculateArea();
        }
        public static double GetVolume(I3DShape shape)
        {
            return shape.CalculateVolume();
        }
    }
}
