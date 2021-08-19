using System;

namespace Computer
{
    public class CalculatorInputToOperationsConvertor
    {
        //TODO: return Shape depending on user input
        public static CalculatorOperations ReturnUserInputAsOperation(string userChosenOperation)
        {
            string userChosenOperationNoCaps = userChosenOperation.ToLower();

            if (userChosenOperationNoCaps.Equals("add"))
            {
                return CalculatorOperations.Add;
            }
            else if (userChosenOperationNoCaps.Equals("subtract"))
            {
                return CalculatorOperations.Subtract;
            }
            else if (userChosenOperationNoCaps.Equals("multiply"))
            {
                return CalculatorOperations.Multiply;
            }
            else if (userChosenOperationNoCaps.Equals("divide"))
            {
                return CalculatorOperations.Divide;
            }
            else if (userChosenOperationNoCaps.Equals("exponent"))
            {
                return CalculatorOperations.Exponent;
            }
            else if (userChosenOperationNoCaps.Equals("root"))
            {
                return CalculatorOperations.Root;
            }
            else if (userChosenOperationNoCaps.Equals("log"))
            {
                return CalculatorOperations.Logarithm;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

    }
}