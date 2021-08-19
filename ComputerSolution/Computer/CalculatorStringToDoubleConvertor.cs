using System;

namespace Computer
{
    public class CalculatorStringToDoubleConvertor
    {
        public static double StringToDouble(string stringToConvert)
        {
            double userNum = 0;
            bool canItBeConvertedToDouble = Double.TryParse(stringToConvert, out userNum);
        
            if(canItBeConvertedToDouble)
            {
                return userNum;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}