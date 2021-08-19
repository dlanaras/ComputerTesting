using System;

namespace Computer
{
    public class CalculatorLogarithm
    {
        public static double LogWithBaseAndRadicand(double logBase, double logRadicand)
        {
            if (Double.IsFinite(logBase) && Double.IsFinite(logRadicand))
            {
                // logExponent = how many times logBase times itself = logRadicand
                double LogExponent = 0;

                while(!logBase.Equals(logRadicand)) //FIXME:
                {
                    LogExponent++;
                    logBase *= logBase;
                }
                
                return LogExponent;
            }
            else
            {
                throw new OverflowException();
            }
        }
    }
}