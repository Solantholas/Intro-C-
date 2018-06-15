/*  Corey Hicks
    3 September 2017
    Business System Programming
    Assignment 6.3

        This program declares an array with 5 integers that run through a loop 10 times. A try, catch error check is used to "catch"
    the inevitable error and display a custom error message to the user. First, the integer array is declared with 5 values. Second,
    the try block is initialized with a for loop that runs 10 times. Third, a catch block is initialized to catch the 
    "IndexOutOfRangeException" error that occurs once the loop tries to run a 6th time. Finally, a custom error message is displayed.   */

using System;

namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5] { 123, 204, 601, 609, 612 }; // declares array with 5 integer elements

            try     // begins try block
            {
                for (int Count = 0; Count < 10; Count++)    // initializes for loop that runs 10 iterations
                {
                    Console.WriteLine(myArray[Count]);  // displays the array element that corresponds to the correct iteration of the loop
                }
            }

            catch (IndexOutOfRangeException)    // begins catch block for IndexOutOfRangeException
            {
                Console.WriteLine("Now you've gone beyond the bounds of the array.");   // custom error message display
            }  
        }
    }
}
