using CalculatoriBrat.Class.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatoriBrat.Class
{
    internal class Calcutaorcs : ICalculatorBasic
    {
        public double Addition(double valuel, double valuel2)
        {
            return valuel + valuel2;
        }

     
        public double Division(double valuel, double valuel2)
        {
            return valuel / valuel2;
        }

        public double Multiplication(double valuel, double valuel2)
        {
            return valuel * valuel2;
        }

        public double Substraction(double valuel, double valuel2)
        {
            return valuel - valuel2;
        }
    }
}
