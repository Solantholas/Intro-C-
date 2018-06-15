/*  Corey Hicks
    12 August 2017
    Business System Programming
    Assignment 3.3

        This application prompts the user to enter a trip distance and uses that value to determine the price of the trip. First, the user is prompted 
    to enter a trip distance in miles. Second, console.readline is used to read the entered value and converts the value ToInt32 before assigning the 
    value to Miles. Third, a series of if, and else if statements are used to determine if Miles equals <=99, <99 but >=299, <299 but >=499, or <=500. 
    Finally, after the Boolean is true, the program displays the miles entered by the user and the appropriate cost of the trip.    */

using System;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your trip distance in miles: ");   // prompts the user to enter a trip distance
            int Miles = Convert.ToInt32(Console.ReadLine());    // converts the entered number to int32 and assigns the variable to Miles

            if (Miles <= 99)    // boolean to determine if user input was less than or equal to 99
            {
                Console.WriteLine("A trip for {0} miles will cost $25.00.", Miles); // displays the user entered distance and the appropriate cost of the trip
            }

            else if (Miles > 99 && Miles <= 299)    // boolean to determine if user input was between 100 and 299 miles
            {
                Console.WriteLine("A trip for {0} miles will cost $40.00.", Miles); // displays the user entered distance and the appropriate cost of the trip
            }

            else if (Miles > 299 && Miles <= 499)   // boolean to determine if user input was between 300 and 499 miles
            {
                Console.WriteLine("A trip for {0} miles will cost $55.00.", Miles); // displays the user entered distance and the appropriate cost of the trip
            }

            else if (Miles >= 500)  // boolean to determine if user input was greater than or equal to 99
            {
                Console.WriteLine("A trip for {0} miles will cost $70.00.", Miles); // displays the user entered distance and the appropriate cost of the trip
            }
        }
    }
}
