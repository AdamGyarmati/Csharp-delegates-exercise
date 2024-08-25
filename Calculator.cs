using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesexercise
{
    public class Calculator
    {
        public delegate double MathOperation(double x, double y);
        public double Calculate(MathOperation mathOperation,double x,double y)
        {
            double művelet = mathOperation(x, y);
            return művelet;
        }
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Substract(double x, double y)
        {
            return x - y;
        }
        public static double Divide(double x, double y)
        {
            return x / y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}
