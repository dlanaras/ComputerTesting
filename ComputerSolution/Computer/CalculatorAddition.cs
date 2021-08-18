using System;

namespace Computer
{
    public class CalculatorAddition
    {
        public double Add(double summand, double addend)
        {
            if (Double.IsInfinity(addend + summand))
            {
                throw new ArithmeticException();
            }
            else
            {
                return summand + addend;
            }

        }
    }
}
