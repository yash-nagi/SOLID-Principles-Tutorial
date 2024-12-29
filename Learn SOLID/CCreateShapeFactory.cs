using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_SOLID
{
    internal class CCreateShapeFactory
    {
        public static I2DShape CreateCircle(double radius) => new CCircle(radius);
        public static I2DShape CreateRectangle(double length, double breadth) => new CRectangle(length, breadth);
        public static I2DShape CreateSquare(double side) => new CSquare(side);
        public static I3DShape CreateCube(double side) => new CCube(side);
    }
}
