namespace Learn_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            I2DShape circle = CCreateShapeFactory.CreateCircle(55.1);
            I2DShape rectangle = CCreateShapeFactory.CreateRectangle(14, 32);
            I2DShape square = CCreateShapeFactory.CreateCircle(4);
            I3DShape cube = CCreateShapeFactory.CreateCube(5);
            new CPrinter().Print(CCalculator.GetArea(circle));
            new CPrinter().Print(CCalculator.GetArea(rectangle));
            new CPrinter().Print(CCalculator.GetArea(square));
            new CPrinter().Print(CCalculator.GetVolume(cube));
        }
        
    }
}