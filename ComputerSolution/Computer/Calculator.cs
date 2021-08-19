using System;

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

        //TODO: Handle Exception with try and catch
        //TODO: first check which operation then get numbers


        private void setUserCalcOps()
        {
            string userSuggestedOperation = this.AskUserWhichOperation();
            try
            {
                this.CalcOps = CalculatorInputToOperationsConvertor.ReturnUserInputAsOperation(userSuggestedOperation);
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine("That's not a valid operation\n");
                this.setUserCalcOps();
            }

        }


        private string AskUserWhichOperation()
        {
            Console.WriteLine("Choose an Operation:\n Add, Subtract, Multiply, Divide, Exponent, Root, Log");
            return Console.ReadLine();
        }

    }
}
