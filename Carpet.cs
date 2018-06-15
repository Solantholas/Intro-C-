/*  Corey Hicks
    3 August 2017
    Business System Programming
    Assignment 2.2

        This simple application computes the total cost of carpet in a room. First, three double variables are declared: Length, Width, and carpetPrice. Second, squareFeet is calculated
    by multiplying Length times Width. Third, totalPrice is calculated by multiplying carpetPrice by squareFeet. Finally, the program displays all values in an intelligent fashion for
    the user to read easily     */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            double Length = 15;         // declares double Length equals 15
            double Width = 20;          // declares double Width equals 20
            double carpetPrice = 3.55;  // declares double carpetPrice equals 3.55

            double squareFeet = Length * Width;             // computes square footage by multiplying length times width
            double totalPrice = carpetPrice * squareFeet;   // computes total cost of carpet by multiplying squareFeet by carpetPrice

            Console.WriteLine("A room that is {0} feet long and {1} feet wide equals {2} square feet.", Length, Width, squareFeet); // displays length, width, and square footage
            Console.WriteLine("Carpeting the room at {0} per square foot would cost {1}.", carpetPrice.ToString("C2"), totalPrice.ToString("C2"));

// .ToString("C2") is used to convert the doubles carpetPrice and totalPrice to a standard US currency string. C stands for currency and 2 denotes 2 decimal places (Microsoft, 2017).

            Console.WriteLine();
        }
    }
}

/*  Reference       

    Microsoft, (2017). Standard Numeric Format Strings. Retrieved from https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings */
