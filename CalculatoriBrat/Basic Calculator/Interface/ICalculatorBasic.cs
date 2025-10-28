using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatoriBrat.BasicCalculators.Interface
{
    public interface ICalculatorBasic
    {
        double Addition(double value1, double value2);
        double Substraction(double value1, double value2);
        double Multiplication(double value1, double value2);
        double Division(double value1, double value2);
        double Calculate(double num1, double num2, char operation);
    }
}