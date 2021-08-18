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
                bool baseAndExponentarentNegativeAndAreFinite = Double.IsFinite(power) && baseNum > 0 && exponent > 0;
                if (baseAndExponentarentNegativeAndAreFinite)
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