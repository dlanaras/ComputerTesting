namespace Computer
{
    class Calculator
    {
        private double firstNum;
        private double secondNum;

        private double result;

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

        //TODO: Handle Exception with try and catch
        //TODO: add class for convertion to double from string
    }
}
