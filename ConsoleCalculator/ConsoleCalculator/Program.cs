


namespace MyCalculator
{
    public static class Calculator
    {
        /*****************************
         * 
         * Fucntion to sum numbers
         * 
         * ***************************/
        public static int sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        /*****************************
         * 
         * Fucntion to perform multiplication
         * 
         * ***************************/
        public static int multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        /*****************************
         * 
         * Fucntion to perform substraction
         * 
         * ***************************/
        public static int substract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        /*****************************
         * 
         * Fucntion to divide numbers
         * 
         * ***************************/
        public static float Divide(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("Cannot be divided by 0. Check your values and try again");
                return 0.0f;
            }
            else
            {
                return (firstNumber / secondNumber);
            }
        }
        
    }
}