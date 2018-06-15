/*  Corey Gruhn-Hicks
    Assignment 8.1
    Intro to Programming Using C#

        This program introduces arrays and continues our understanding of random number generators. First, the program calls an instance of the Random class and assigns myRandom as a new Random. Second, the program instantiates
    a new array called randomGenerator with a length of 10. Third, the program enters a for loop that loops the length of the array assigning random numbers to each variable within the array. Finally, the program enters a second
    for loop to display each random number that has been assigned to array. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            Random myRandom = new Random(); // calls the random class and assigns the class to myRandom

            int[] randomGenerator = new int[10];    // creates a new instance of an int array with a length of 10

            for (int Count = 0; Count < randomGenerator.Length; Count++)    // enters a for loop with a loop count equal to the length of the array (10)
            {
                randomGenerator[Count] = myRandom.Next(1, 1000);    // assigns each variable within the array a random number between 1 and 1000
            }

            for (int Count = 0; Count < randomGenerator.Length; Count++)    // enters a for loop with a loop count equal to the length of the array (10)
            {

                Console.WriteLine("The array value is: " + randomGenerator[Count]); // displays the random number assigned to each variable within the array
            }  
        }
    }
}
