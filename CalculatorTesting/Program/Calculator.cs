using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTesting
{
    class Calculator
    {
        public double Add(double a, double b) 
        {
            return a + b;
        }

        public double Substract(double a, double b) 
        {
            return a - b;
        }

        public double Multiply(double a, double b) 
        {
            return a * b;
        }

        public double Divide(double a, double b) 
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Divizion by zero!");
                return 0;
            }
        }
    }
}
