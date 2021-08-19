using System;

namespace Computer
{
    public class CalculatorAddition
    {
        public static double Add(double summand, double addend)
        {
            if (Double.IsInfinity(addend + summand))
            {
                throw new OverflowException();
            }
            else
            {
                return summand + addend;
            }

        }
    }
}
