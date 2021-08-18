//IMPORTANT: log uses base and result to get exponent
using System;

namespace Computer
{
    public class CalculatorLogarithm
    {
        public double LogWithBaseAndRadicand(double logBase, double logRadicand)
        {
            if (Double.IsFinite(logBase) && Double.IsFinite(logRadicand))
            {
                // logExponent = how many times logBase times itself = logRadicand
                double LogExponent = 0;

                while(!logBase.Equals(Math.Abs(logRadicand)))
                {
                    LogExponent++;
                    logBase *= logBase;
                }
                
                return LogExponent;
            }
            else
            {
                throw new ArithmeticException();
            }
        }
    }
}