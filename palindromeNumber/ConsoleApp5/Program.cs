using System;
public class PalindromeNumbers
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int num=int.Parse(Console.ReadLine()), sum = 0, temp, rem;
        temp = num;  // Storing the original number in a temporal variable
        while(num> 0)
        {
            rem = num% 10; //Gets the remainder each time the number is divided by 10
            sum = (sum * 10) + rem; //Takes the sum, multiply by 10 and add the remainder to it
            //Console.WriteLine(sum);
            num = num/10; //Dividing the original number by 10
        }
        if (temp == sum) {
            Console.WriteLine("The number is a palindrome");
        }
        else { Console.WriteLine("The number is not a palindrome"); }
    }
}