    /*  Corey Gruhn-Hicks
        Week 7 Extra Credit
        Intro to Programming Using C#

            This program prompts the user to enter a low and high range value for a random generated number. Main calls the 1st method in the program which prompts the user to enter the range values.
        After the method assigns the values to low and high respectively the 1st method calls the 2nd method. In the 2nd method a random number is generated with the range limits assigned in the 1st 
        method. The 2nd method then calls the 3rd method to print the low, high, and random number. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_ExtraCredit_Gruhn_Hicks
{
    class Program
    {
        static void Main(string[] args)
        {
            getRange(); // calls the getRange method into Main
        }

        static void getRange()
        {
            Console.Write("Enter the low integer range number: "); // prompts the user to enter a low range integer
            int Low = Convert.ToInt32(Console.ReadLine());  // assigns the input number to int Low

            Console.Write("Enter the high integer range number: "); // prompts the user to enter a high range integer
            int High = Convert.ToInt32(Console.ReadLine()); // assigns the input number to int High

            getRandom(Low, High); // calls the 2nd method to the 1st method
        }

        static void getRandom(int Low, int High)  // creates the method getRandom with int Low and int High signature
        {
            Random myRandom = new Random(); // calls the random class and assigns the class to myRandom
            int randomNumber = myRandom.Next(Low, High);   // instantiates the integer randomNumber and assigns it a value of myRandom.Next with a limit of Low and High

            Print(Low, High, randomNumber); // calls the 3rd method to the 2nd method
        }

        static void Print(int Low, int High, int randomNumber)  // creates the method Print with int low, int High, and int Random number signature
        {
            Console.WriteLine("Random number from range {0} and {1} is {2}.", Low, High, randomNumber); // displays the random number range and the random number
        }
    }
}
