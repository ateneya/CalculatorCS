using CalculatoriBrat.AdvencedCalculators.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatoriBrat.Advanced_Calculator.Interface
{
    internal class Calculator : ICalculatorAdvanced
    {
        public double Cos(double value)
        {
            double result = 1;
            double term = 1;
            int n = 10;

            for (int i = 1; i < n; i++)
            {
                term *= -1 * value * value / ((2 * i - 1) * (2 * i));
                result += term;
            }

            return result;
        }

        public double Power(double value, double exponent)
        {
            if (exponent == 0)
                return 1;
            else if (exponent > 0)
            {
                double result = 1;
                for (int i = 0; i < (int)exponent; i++)
                {
                    result *= value;
                }
                return result;
            }
            else
            {

                double result = 1;
                for (int i = 0; i < (int)(-exponent); i++)
                {
                    result *= value;
                }
                return 1 / result;
            }
        }

        public double Root(double value, double degree)
        {
            double x = value / 2.0;
            for (int i = 0; i < 100; i++)
            {
                x = ((degree - 1) * x + value / Power(x, degree - 1)) / degree;
            }
            return x;
        }

        public double Sin(double value)
        {
            double term = value;
            double sum = term;
            for (int i = 1; i < 10; i++)
            {
                term *= -1 * value * value / ((2 * i) * (2 * i + 1));
                sum += term;
            }
            return sum;

        }

        public double Tan(double value)
        {
            return Sin(value) / Cos(value);
        }
    }
}
