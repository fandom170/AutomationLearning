using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using NUnit;
using NUnit.Framework;

namespace CalculatorTesting
{
    [TestFixture]
    class ScientificCalcTest
    {
        ScientificCalculator scCalculator;
        [OneTimeSetUp]
        public void Starting()
        {
            //something optimistic
            scCalculator = new ScientificCalculator();

        }


        [Test(ExpectedResult = 256)] 
        [Description ("Returning expected result")]
        public double PowCheck()
        {
            return scCalculator.Pow(4, 4);
        }

        [Test, Repeat(5)]
        [Description("Testing of repeat")]
        public void AddingSeverlTimesCheck()
        {
            Assert.That(scCalculator.Add(2, _dataStorage.partValue) == _dataStorage.partValue + 2, Is.True);
            Console.WriteLine(_dataStorage.partValue);
        }

        [Test, Retry(5)]
        public void AddingRetryCheck()
        {
            Assert.That(scCalculator.Add(2, _dataStorage.partValue) == _dataStorage.partValue + 1, "All OK");
            //TestContext.WriteLine(_dataStorage.partValue);
            //MessageBox.Show("text");
        }

        [Test, MaxTime(1)]
        public void AddingWait()
        {
            double n = scCalculator.Pow(5, 25);
            Assert.That(n, Is.GreaterThan(1), "All OK");
        }

        [Test, Ignore(reason: "Ignored for test execution", Until = "2020-03-01")]
        public void TestIgnore()
        {
            //Assert.That(true == false);
        }


        //Starts with
        [Test]
        public void StringStart()
        {
            StringAssert.StartsWith("Wag", scCalculator.StringReturning());
        }

        //Contains
        public void StringContains() 
        {
            StringAssert.Contains("the", scCalculator.StringReturning(), "All OK");
        }

        //Are equal Ignoring case
        [Test, Order(1)]
        public void StringEqualIgnoringCase()
        {
            StringAssert.AreEqualIgnoringCase("wag the DOG", scCalculator.StringReturning());
        }

        //Always pass
        [Test, Order(2)]
        public void AlwaysPass()
        {
            Assert.IsTrue(true == true, "It is obvious!");
        }

        //always fail
        [Test]
        public void AlwaysFail()
        {
            Assert.False(false == false, "False");
        }

        [TearDown]
        public void ThisIsTheEnd() 
        {
            scCalculator = null;
            //something what can be done in the end
        }



    }
}
