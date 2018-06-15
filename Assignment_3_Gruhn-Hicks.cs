/*  Corey Gruhn-Hicks
    Intro to Programming Using C#
    Assignment 3.1
    
    This program takes 2 integers entered by the user and runs each integer against "if" statements. Depending on which "if" statement is true the program will 
    assign new values to the entered integers. Then the program multiplies the 2 values and displays the result.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment3
{
    class changeValue
    {
        //Create a class called changeValue that declares 2 integer class variables:  value1 and 
        //  value2.  These should be declared as public and you should not use automatic properties 
        // to declare them. 

        public int value1;
        public int value2;

        public changeValue(int val1, int val2)
        {
            //here is the constructor where you code the if statements
            if (val1 > 5)
            {
                value1 = val1;
            }

            if (val1 <= 5)
            {
                value1 = val1 + val2;
            }

            if (val2 < 10)
            {
                value2 = val2 * val2 + 5;
            }

            if (val2 >= 10)
            {
                value2 = val2;
            }
        }
        public void printit()
        {
            //here is the printit method used to print the results
            Console.WriteLine("The calculated value is: {0}", (value1 * value2));
        }
    }
    class assignment3
    {
        public static void Main(string[] args)
        {
            //declare the local val1 and val2 integer variables
            int val1;
            int val2;

            //prompt the user for input of two integers
            //don’t forget to convert from the string input to integer
            Console.Write("Enter an integer value: ");
            val1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second integer value: ");
            val2 = Convert.ToInt32(Console.ReadLine());

            //instantiate a changeValue object here
            changeValue myChangeValue = new changeValue(val1, val2);
            //call the object method printit here
            myChangeValue.printit();
        }
    }
}