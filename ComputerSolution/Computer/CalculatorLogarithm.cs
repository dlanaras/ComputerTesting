using System;

namespace Computer
{
    public class CalculatorLogarithm
    {
        public static double LogWithBaseAndRadicand(double logBase, double logRadicand)
        {
            if (logBase < 0 || logRadicand < 0)
            {
                throw new NumberCannotBeNegativeException();
            }
            else if (Double.IsFinite(logBase) && Double.IsFinite(logRadicand))
            {
                // logExponent = how many times logBase times itself = logRadicand
                double LogExponent = 1;
                double logBase1 = logBase;

                while (!logBase.Equals(logRadicand))
                {
                    LogExponent++;
                    logBase *= logBase1;
                    if (logBase > logRadicand)
                    {
                        throw new OverflowException();
                    }
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