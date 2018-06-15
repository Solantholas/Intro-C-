/*  Corey Hicks
    12 August 2017
    Business System Programming
    Assignment 3.2

        This application uses a nested for loop to display a multiplication table for numbers 1 through 10. First, the first for loop will instantly 
    pass control to the nested for loop. Second, the nested for loop will iterate 10 times multiplying the first loops iteration number by the nested
    loops iteration number (ex 1*1, 1*2, 1*3, etc.). Third, the nested for loop will pass control back to the first for loop. Fourth, the first for 
    loop will go to the second iteration and pass control back to the nested loop.     */

using System;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 10; x++)   // initiates the first for loop to run for 10 iterations
            {
                for (int y = 1; y <= 10; y++)   // initiates the nested for loop to run for 10 iterations
                {
                    Console.Write(x * y + "\t");    // multiplies the iteration number of the first loop by the iteration number of the second loop with tab formatting
                }
                Console.WriteLine();    // blank line to return the table to the next row before starting the first loop over
            }
            Console.WriteLine();
        }
    }
}
