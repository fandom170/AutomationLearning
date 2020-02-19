using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTesting
{
    [TestFixture]
    public class TetsForCalculator
    {
        Calculator calculator = new Calculator();
        double a = 6.6;
        double b = 1.4;

        [Test(ExpectedResult = 8)]
        public void TestAdding1(double a, double b) 
        {
            calculator.Add(a, b);
        }

        [TestCase(7.5, 2.5)]
        [TestCase(-5, 5.0)]
        public void TestAdding2(double a, double b)
        {
            calculator.Add(a, b);
        }

    }
}
