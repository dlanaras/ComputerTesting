using System;

namespace Computer
{
    public class CalculatorFactorial
    {
        public static double GetFactorialOf(double factorial)
        {
            if (FactorialDoesntContainDecimalPoints(factorial))
            {
                if (factorial > 0)
                {
                    for (double factorialDecrementer = factorial-1; factorialDecrementer > 0; factorialDecrementer--)
                    {
                        factorial *= factorialDecrementer;
                    }
                    return factorial;
                }
                else if (factorial.Equals(0))
                {
                    return 1; // 0! equals to 1
                }
                else
                {
                    throw new NumberCannotBeNegativeException();
                }
            }
            else
            {
                throw new NumberCannotBeDecimalException();
            }
        }

        private static bool FactorialDoesntContainDecimalPoints(double factorial)
        {
            string factorialAsString = factorial.ToString();
            bool factorialIsInteger = Int32.TryParse(factorialAsString, out _);
            return factorialIsInteger;
        }

    }
}