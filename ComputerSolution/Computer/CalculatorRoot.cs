using System;

namespace Computer
{
    public class CalculatorRoot
    {

        private CalculatorExponentiation calcExponent = new CalculatorExponentiation();

        public double GetRootWithDegreeOfRadicand(double degree, double radicand)
        {

            if (degree.Equals(0))
            {
                throw new DivideByZeroException();
            }
            else
            {
                double aproximateBase = Math.Pow(radicand, 1 / degree); //Really cool conversion from https://stackoverflow.com/questions/18657508/c-sharp-find-nth-root

                if (Double.IsFinite(aproximateBase))
                {
                    return aproximateBase;
                }
                else
                {
                    throw new ArithmeticException();
                }
            }

        }

    }
}