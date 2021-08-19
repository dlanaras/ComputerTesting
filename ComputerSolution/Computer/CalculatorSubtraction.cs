using System;

namespace Computer
{
    public class CalculatorSubtraction
    {
        public static double Subtract(double minuend, double subtrahend)
        {
            double difference = minuend - subtrahend;
            if (!Double.IsInfinity(difference))
            {
                return difference;
            }
            else
            {
                throw new OverflowException();
            }
        }
    }
}