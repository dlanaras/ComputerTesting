using System;

namespace Computer
{
    public class CalculatorExponentiation
    {
        public double GetPowerOfBaseToExponent(double baseNum, double exponent)
        {
            if (!exponent.Equals(0))
            {
                double power = baseNum;
                for (int i = 1; i < exponent; i++)
                {
                    power *= baseNum;
                }

                if (Double.IsFinite(power))
                {
                    return power;
                }
                else
                {
                    throw new ArithmeticException();
                }
            }
            else
            {
                return 1; //If the Exponent is 0 the result is always 1
            }
        }
    }
}