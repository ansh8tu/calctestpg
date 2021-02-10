using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Div(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            double result = a / b;
            return result;
        }
    }
}
