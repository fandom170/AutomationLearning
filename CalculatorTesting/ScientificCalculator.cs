using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTesting
{
    class ScientificCalculator : Calculator
    {
        public double Pow(double basis, double degree) 
        {
            return Math.Pow(basis, degree);
        }

        public double Abs(double basis) 
        {
            return Math.Abs(basis);
        }

        public double Percent(double basis, double percent) 
        {
            return (basis * percent) / 100;
                 
        }

        public double MaxArray(double[] data) 
        {
            double max = data [0];
            for (int i = 1; i < data.Length; i++) 
            {
                if (data[i] > max) 
                {
                    max = data[i];
                }
            }
            return max;
        }

        public double MinArray(double[] data)
        {
            double min = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] < min)
                {
                    min = data[i];
                }
            }
            return min;
        }

        public string StringReturning() 
        {
            string dataString = "Wag the dog";
            Console.WriteLine(dataString);
            return dataString;

        }
    }
}
