/*  Corey Hicks
    3 August 2017
    Business System Programming
    Assignment 2.3

        This simple application prompts the user to choose a wood species and displays the value of the chosen species. First, four doubles are declared: Pine, Oak, Mahogany, and Invalid.
    Second, a dialog prompts the user to make a selection for the desired species of wood. Third, console.readline is used to read the entered value and converts the value toString
    before assigning the value to woodSpecies. Fourth, a series of if, and else if statements are used to determine if the user entered value equals P, O, M, or any other character.
    Finally, after the boolean is true, the program displays the proper price for the wood species selected by the user.    */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pine = 100;     // declares int Pine equals 100
            int Oak = 225;      // declares int Oak equals 250
            int Mahogany = 310; // declares int Mahogany equals 310
            int Invalid = 0;    // declares int Invalid equals 0

            Console.WriteLine("Please select a species of wood for your new table. . .");   // dialog for user prompt
            Console.WriteLine("Type 'P' for Pine.");
            Console.WriteLine("Type 'O' for Oak.");
            Console.WriteLine("Type 'M' for Mahogany.");
            string woodSpecies = Convert.ToString(Console.ReadLine());  // converts user input to string and assigns woodSpecies the value

            if (woodSpecies == "P") // boolean to determine if user input was P
            {
                Console.WriteLine("A Pine table is {0}.", Pine.ToString("C2")); // displays the price of pine tables using US currency
            }

            else if (woodSpecies == "O")    // boolean to determine if user input was O
            {
                Console.WriteLine("An Oak table is {0}.", Oak.ToString("C2"));  // displays the price of oak tables using US currency
            }

            else if (woodSpecies == "M")    // boolean to determine if user input was M
            {
                Console.WriteLine("A Mahogany table is {0}.", Mahogany.ToString("C2")); // displays the price of Mahogany tables using US currency
            }

            else   // end of boolean statement, catches all other input besides P, O, and M
            {
                Console.WriteLine("Invalid selection. {0}.", Invalid.ToString("C2"));   // displays invalid selection using US currency
            }
        }
    }
}
