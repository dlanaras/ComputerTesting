using System;
using System.Threading;


namespace Computer
{
    public class Calculator
    {
        private double firstNum;
        private double secondNum;

        private double result;

        private CalculatorOperations calcOps = new CalculatorOperations();

        public double FirstNum
        {
            get => this.firstNum;
            set
            {
                this.firstNum = value;
            }
        }

        public double SecondNum
        {
            get => this.secondNum;
            set
            {
                this.secondNum = value;
            }
        }

        public double Result
        {
            get => this.result;
            set
            {
                this.result = value;
            }
        }

        public CalculatorOperations CalcOps
        {
            get => this.calcOps;

            set
            {
                this.calcOps = value;
            }
        }


        public void UseCalculator()
        {
            this.TurnCalculatorOn();
            string doneWithUsingCalc = "";
            while (!doneWithUsingCalc.Equals("n"))
            {
                this.setUserCalcOps();

                switch (this.CalcOps)
                {
                    case CalculatorOperations.Add:
                        this.AdditionExceptionHandling();
                        break;

                    case CalculatorOperations.Subtract:
                        this.SubtractionExceptionHandling();
                        break;

                    case CalculatorOperations.Multiply:
                        this.MultiplicationExceptionHandling();
                        break;

                    case CalculatorOperations.Divide:
                        this.DivisionExceptionHandling();
                        break;

                    case CalculatorOperations.Exponent:
                        this.ExponentExceptionHandling();
                        break;

                    case CalculatorOperations.Root:
                        this.RootExceptionHandling();
                        break;

                    case CalculatorOperations.Logarithm:
                        this.LogarithmExceptionHandling();
                        break;
                    case CalculatorOperations.Factorial:
                        this.FactorialExceptionHandling();
                        break;
                    default:
                        throw new Exception("CalcOps should be defined");
                }

                Console.WriteLine($"The Result is {this.Result}");
                Console.WriteLine("Want to calculate anything else y/n?");
                doneWithUsingCalc = Console.ReadLine();
            }
            this.TurnCalculatorOff();
        }


        private void FactorialExceptionHandling()
        {
            try
            {
                this.setUserNums("factorial");
                this.Result = CalculatorFactorial.GetFactorialOf(this.FirstNum);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number you entered is too large\n");
                this.FactorialExceptionHandling();
            }
            catch (NumberCannotBeDecimalException)
            {
                Console.WriteLine("Factorials with decimal points are not supported, please reffer to Gamma Function online\n");
                this.FactorialExceptionHandling();
            }
            catch (NumberCannotBeNegativeException)
            {
                Console.WriteLine("Negative numbers are not supported\n");
                this.FactorialExceptionHandling();
            }
        }
        private void ExponentExceptionHandling()
        {
            try
            {
                this.setUserNums("base", "exponent");
                this.Result = CalculatorExponentiation.GetPowerOfBaseToExponent(this.FirstNum, this.SecondNum);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The numbers you entered are too large or have to many decimal places\n");
                this.ExponentExceptionHandling();
            }
            catch (NumberCannotBeNegativeException)
            {
                Console.WriteLine("Negative Exponents are unsupported");
                this.ExponentExceptionHandling();
            }
        }

        private void RootExceptionHandling()
        {
            try
            {
                this.setUserNums("degree", "radicand");
                this.Result = CalculatorRoot.GetRootWithDegreeOfRadicand(this.FirstNum, this.SecondNum);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The numbers you entered are too large or have to many decimal places\n");
                this.RootExceptionHandling();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Degree cannot be 0, because dividing by 0 is not possible\n");
                this.RootExceptionHandling();
            }
        }

        private void LogarithmExceptionHandling()
        {
            try
            {
                this.setUserNums("base", "radicand");
                this.Result = CalculatorLogarithm.LogWithBaseAndRadicand(this.FirstNum, this.SecondNum);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The numbers you entered are too large, have to many decimal places or are just dont result in a non decimal exponent\n");
                this.LogarithmExceptionHandling();
            }
            catch (NumberCannotBeNegativeException)
            {
                Console.WriteLine("Negative Numbers aren't supported\n");
                this.LogarithmExceptionHandling();
            }

        }

        private void DivisionExceptionHandling()
        {
            try
            {
                this.setUserNums("dividen", "divisor");
                this.Result = CalculatorDivision.Divide(this.FirstNum, this.SecondNum);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The numbers you entered are too large or have to many decimal places\n");
                this.DivisionExceptionHandling();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.\n");
                this.DivisionExceptionHandling();
            }

        }

        private void MultiplicationExceptionHandling()
        {
            try
            {
                this.setUserNums("factor", "multiplicand");
                this.Result = CalculatorMultiplication.Multiply(this.FirstNum, this.SecondNum);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The numbers you entered are too large or have to many decimal places\n");
                this.MultiplicationExceptionHandling();
            }

        }


        private void SubtractionExceptionHandling()
        {
            try
            {
                this.setUserNums("minuend", "subtrahend");
                this.Result = CalculatorSubtraction.Subtract(this.FirstNum, this.SecondNum);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The numbers you entered are too large or have to many decimal places\n");
                this.SubtractionExceptionHandling();
            }

        }

        private void AdditionExceptionHandling()
        {
            try
            {
                this.setUserNums("summand", "addend");
                this.Result = CalculatorAddition.Add(this.FirstNum, this.SecondNum);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The numbers you entered are too large or have to many decimal places\n");
                this.AdditionExceptionHandling();
            }

        }

        private void TurnCalculatorOff()
        {
            Console.Clear();
            Console.WriteLine("Calculator has been turned off. Press any key to close this window.");
            Console.ReadKey();
        }

        private void TurnCalculatorOn()
        {
            Console.Write("Starting Calculator: \nProgress:|");
            for (int i = 0; i < 50; i++)
            {
                Console.Write("*");
                Thread.Sleep(30);
            }
            Console.WriteLine("|\nCalculator has Started\n");
        }

        private void setUserNums(string firstNumMathName, string secondNumMathName)
        {

            string firstStringToConvertToDouble = this.getUserStringToConvertToDouble(firstNumMathName);
            string secondStringToConvertToDouble = this.getUserStringToConvertToDouble(secondNumMathName);
            try
            {
                this.FirstNum = CalculatorStringToDoubleConvertor.StringToDouble(firstStringToConvertToDouble);
                this.SecondNum = CalculatorStringToDoubleConvertor.StringToDouble(secondStringToConvertToDouble);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("That's not a valid number. Try again.\n");
                this.setUserNums(firstNumMathName, secondNumMathName);
            }
        }

        private void setUserNums(string numMathName)
        {
            string stringToConvertToDouble = this.getUserStringToConvertToDouble(numMathName);
            try
            {
                this.FirstNum = CalculatorStringToDoubleConvertor.StringToDouble(stringToConvertToDouble);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("That's not a valid number. Try again.\n");
                this.setUserNums(numMathName);
            }
        }

        private string getUserStringToConvertToDouble(string mathematicalNumName)
        {
            Console.WriteLine($"Enter a {mathematicalNumName}: ");
            return Console.ReadLine();
        }

        private void setUserCalcOps()
        {
            string userSuggestedOperation = this.AskUserWhichOperation();
            try
            {
                this.CalcOps = CalculatorInputToOperationsConvertor.ReturnUserInputAsOperation(userSuggestedOperation);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("That's not a valid operation\n");
                this.setUserCalcOps();
            }

        }

        private string AskUserWhichOperation()
        {
            Console.WriteLine("Choose an Operation:\n Add, Subtract, Multiply, Divide, Exponent, Root, Log, Factorial");
            return Console.ReadLine();
        }

    }
}
