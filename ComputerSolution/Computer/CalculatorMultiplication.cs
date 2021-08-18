using System;

namespace Computer
{
    public class CalculatorMultiplication
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