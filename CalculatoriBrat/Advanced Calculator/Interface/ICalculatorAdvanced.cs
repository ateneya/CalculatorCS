using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatoriBrat.AdvencedCalculators.Interface
{
    public interface ICalculatorAdvanced
    {
        double Root(double value, double degree);
        double Power(double value, double exponent);
        double Sin(double value);
        double Cos(double value);
        double Tan(double value);
    }
}