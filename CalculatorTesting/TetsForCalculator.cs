﻿using NUnit.Framework;
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

        [Test, Combinatorial]
        public void TestAdding1(
            [Values(6.6, 1.4, -3.0)] double a,
            [Values (5.31, -9.14, 0.0)] double b
            ) 
        {
            calculator.Add(a, b);
        }

        [TestCase(7.5, 2.5)]
        [TestCase(-5, 5.0)]
        public void TestAdding2(double a, double b)
        {
            calculator.Add(a, b);
        }

        [Test(ExpectedResult = 8)]
        public double TestAdding3()
        {
            return (calculator.Add(6.6, 1.4));
        }

        [Test(Description ="Check of values adding")]
        public void TestAdding4(double a, double b)
        {
            Assert.That(calculator.Add(a, b) == 8.0);
        }

    }
}
