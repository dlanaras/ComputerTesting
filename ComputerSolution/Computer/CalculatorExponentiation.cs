using System;

namespace Computer
{
    public class CalculatorExponentiation
    {
        public static double GetPowerOfBaseToExponent(double baseNum, double exponent)
        {
            if (!exponent.Equals(0))
            {
                double power = baseNum;
                bool baseAndExponentArentNegativeAndAreFinite = Double.IsFinite(power) && baseNum > 0 && exponent > 0;
                for (int i = 1; i < exponent; i++)
                {
                    power *= baseNum;
                }

                if (baseAndExponentArentNegativeAndAreFinite)
                {
                    return power;
                }
                else
                {
                    throw new OverflowException();
                }
            }
            else
            {
                return 1; //If the Exponent is 0 the result is always 1
            }
        }
    }
}