using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_SOLID
{
    internal class CPrinter : IPrint
    {
        public CPrinter()
        {
            
        }
        public void Print(double value)
        {
            Console.WriteLine(value);
        }
    }
}
