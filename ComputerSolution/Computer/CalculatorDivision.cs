using System;

namespace Computer
{
    public class CalculatorDivision
    {
        public double Divide(double dividend, double divisor)
        {
            if (!divisor.Equals(0))
            {
                if (Double.IsFinite(dividend / divisor))
                {
                    return dividend / divisor;
                }
                else
                {
                    throw new ArithmeticException();
                }
            }
            else
            {
                throw new DivideByZeroException();
            }

        }
    }
}