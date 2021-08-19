using System;

namespace Computer
{
    public class CalculatorDivision
    {
        public static double Divide(double dividend, double divisor)
        {
            if (!divisor.Equals(0))
            {
                if (Double.IsFinite(dividend / divisor))
                {
                    return dividend / divisor;
                }
                else
                {
                    throw new OverflowException();
                }
            }
            else
            {
                throw new DivideByZeroException();
            }

        }
    }
}