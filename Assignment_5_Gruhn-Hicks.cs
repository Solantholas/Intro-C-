/*  Corey Gruhn-Hicks
    Assignment 5.1
    Intro to Programming Using C#

    This program utilizes for loops to insert asterisks and numbers in an ascending and then descending order. First the loop will determine
    how many passes the loop will run and if the loop will ascend or descend as the control number is incremented. Within the scope of the
    loop the program will insert an asterisk based on the increment count as well as add the increment count multiplied by two directly 
    following the asterisk. */

using System;

namespace Example_Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 10; x++)   // begins the for loop in ascending increment
            {
                Console.Write(new string('*', x));  // inserts asterisks as a string. The number of asterisks is determined by the current value of int x.
                Console.WriteLine("{0}", x * 2);    // inserts the value of x multiplied by 2 directly after the asterisks.
            }

            Console.WriteLine();

            for (int x = 10; x >= 1; x--)   // begins a new for loop in descending increment
            {
                Console.Write(new string('*', x)); // scope is exactly the same as the above for loop.
                Console.WriteLine("{0}", x * 2);
            }

            Console.WriteLine();
        }
    }
}
