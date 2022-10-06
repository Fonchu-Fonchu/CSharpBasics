using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCalculator;

namespace ConsoleCalculator { 

internal class calculator
{
        public static void Main()
        {
            int num1;
            int num2;
            Console.WriteLine("Please choose an operator +, -, *, or /");
            char typeOperator = Char.Parse(Console.ReadLine());
            if (typeOperator != '+' || typeOperator != '+' || typeOperator != '+' || typeOperator != '+')
            {
                Console.WriteLine(
                    typeOperator
                    + " "
                    + "is not a valid basic math operator"
               );
            }
            else
            {
                Console.Write("Enter first number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(typeOperator);
                if (typeOperator == '+')
                {
                    Console.WriteLine(Calculator.sum(num1, num2));
                }
                else if (typeOperator == '-')
                {
                    Console.WriteLine(Calculator.substract(num1, num2));
                }
                else if (typeOperator == '*')
                {
                    Console.WriteLine(Calculator.multiply(num1, num2));
                }
                else if (typeOperator == '/')
                {
                    Console.WriteLine(Calculator.Divide(num1, num2));
                }
                else
                {
                    Console.WriteLine(typeOperator + " " + "is not a valid basic math operator");
                }
            }
        }
    }
}


