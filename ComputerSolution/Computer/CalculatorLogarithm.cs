//IMPORTANT: log uses base and result to get exponentusing System;
using System;

namespace Computer
{
    public class CalculatorLogarithm
    {
        public double Multiply(double factor, double multiplicand)
        {
            if (Double.IsFinite(factor * multiplicand))
            {
                return factor * multiplicand;
            }
            else
            {
                throw new ArithmeticException();
            }
        }
    }
}