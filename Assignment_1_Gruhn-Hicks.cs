/*  Corey Gruhn-Hicks
    Intro to Programming Using C#
    Assignment 1.1
    13 March 2017
    
    This program will prompt the user to enter a total of 3 whole numbers. After the numbers have been entered the program will perform 3 different calculations:
    calculate the sum of the numbers, calculate the average of the numbers, and calculate any remainder following the average. After calculations are performed by
    the program it will display the 3 numbers along with the average and remainder of the average.*/

using System;


namespace Assignment_1_GruhnHicks
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable1; // declares variable1 as an interger
            int variable2; // declares variable2 as an integer
            int variable3; // declares variable3 as an integer


            Console.Write("Enter your first integer: "); // prompts the user to enter a whole number
            variable1 = Convert.ToInt32(Console.ReadLine()); // program reads the number entered by the user

            Console.Write("Enter your second integer: "); // prompts the user to enter a whole number
            variable2 = Convert.ToInt32(Console.ReadLine()); // program reads the number entered by the user

            Console.Write("Enter your third integer: "); // prompts the user to enter a whole number
            variable3 = Convert.ToInt32(Console.ReadLine()); // program reads the number entered by the user

            int sum = variable1 + variable2 + variable3; // declares sum as an integer equaling the sum of all three variables
            int average = sum / 3; // declares average as an integer equaling the average of all 3 variables
            int remainder = sum % 3; // declares remainder as an integer equaling the remainder after finding the average of all 3 variables (Microsoft, 2015).

            Console.WriteLine("The average of {0}, {1}, and {2} is {3} with a remainder of {4}  ", variable1, variable2, variable3, average, remainder);
            // displays the 3 variables entered by the user with the calculated average of all 3 variables and any remainder after calculation
        }
    }
}

/*  References
    Microsoft (2015). % Operator (C# Reference). Retrieved from
    https://msdn.microsoft.com/en-us/library/0w4e0fzs.aspx  */
