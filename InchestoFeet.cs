/*  Corey Hicks
    20 August 2017
    Business System Programming
    Assignment 4.2

        This application uses a static method to convert inches to inches and feet. First, an integer is declared with an assigned value for inches.
    Second, control is passed to the InchestoFeet method with inches variable assigned as a signature. Third, calculations are done to divide inches
    by 12 with a remainder. Third, the InchestoFeetMethod displays the original inches variable, the feet and the inches remainder. Finally, control 
    is passed back to the Main method before ending.    */

using System;

namespace ConsoleApplication29
{
    class Program
    {
        static void Main(string[] args)
        {
            int Inches = 74;    // declares inches as an int variable

            InchestoFeet(Inches);   // invokes the InchestoFeet method with inches int as a passed variable
        }

        static void InchestoFeet(int Inches)    // begins the InchestoFeet void method with inches as a signature
        {
            int Feet = Inches / 12;     // calculates feet by dividing inches variable by 12
            int Remainder = Inches % 12;    // calulates remaining inches by using the % operand and dividing inches by 12

            Console.WriteLine("{0} inches is equal to {1} feet and {2} inches.", Inches, Feet, Remainder);
            // console display of the original variable and the conversions
        }
    }
}
