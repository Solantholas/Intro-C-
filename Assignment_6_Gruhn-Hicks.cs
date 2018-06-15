/*  Corey Gruhn-Hicks
    Assignment 6.1
    Intro to Programming Using C#

        This program uses a while loop to calculate user input for 2 sides of a right triangle and calculate the hypotenuse (pythagorean theorem). A sentinel is
    used as a controler to exit the while loop when the user enters a 0 for both sides of the triangle. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_Gruhn_Hicks
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1 = 1;   // instantiates side1 as a double
            double side2 = 1;   // instantiates side2 as a double

            Console.WriteLine("Enter 0 for both side 1 and side 2 to exit . . .");  // displays the scope of exiting the program
            Console.WriteLine();

            while (side1 != 0 && side2 != 0)    // initiates the loop while side1 and side2 are not equal to 0
            {
                Console.Write("Enter the length of the first side: ");  // prompts the user to enter the first side
                side1 = Convert.ToDouble(Console.ReadLine());   // converts the entered number to the value of double side 1

                Console.Write("Enter the length of the second side: "); // prompts the user to enter the second side
                side2 = Convert.ToDouble(Console.ReadLine());   // converts the entered number to the value of double side 1
                double side3 = ((side1 * side1) + (side2 * side2)); // instantiates side3 as a double equal to side1 squared plus side2 squared

                double side3sqrt = Math.Sqrt(side3);    // instantiates side3sqrt as a double equal to the square root of side3

                if (side1 != 0 && side2 != 0) // initiates a boolean that is only true if side1 and side2 are not equal to zero
                {
                    Console.WriteLine("The hypotenuse is {0}", side3sqrt); // displays the hypotenuse of the triangle
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}