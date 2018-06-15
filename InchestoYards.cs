/*  Corey Hicks
    20 August 2017
    Business System Programming
    Assignment 4.2

        This application uses a static method to convert inches to inches and feet. First, an integer is declared with an assigned value for inches.
    Second, control is passed to the InchestoFeet method with inches variable assigned as a signature. Third, calculations are done to divide inches
    by 12 with a remainder. Third, the InchestoFeet method displays the original inches variable, the feet and the inches remainder. Fourth, control 
    is passed back to the Main method before invoking the InchestoYards method with inches variable assigned as a signature. Fifth, calculations are
    done to divide inches by 36 and find the total yards as well as the remaining feet and inches. Finally, control is passed back to the Main 
    method before the application ends. */

using System;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            int Inches = 74;    // declares inches as an int variable

            InchestoFeet(Inches);   // invokes the InchestoFeet method with inches int as a passed variable
            InchestoYards(Inches);  // invokes the InchestoYards method with inches int as a passed variable
        }

        static void InchestoFeet(int Inches)    // begins the InchestoFeet void method with inches as a signature
        {
            int Feet = Inches / 12;     // calculates feet by dividing inches variable by 12
            int Remainder = Inches % 12;    // calulates remaining inches by using the % operand and dividing inches by 12

            Console.WriteLine("{0} inches is equal to {1} feet and {2} inches.", Inches, Feet, Remainder);
            // console display of the original variable and the conversions
        }

        static void InchestoYards(int Inches)
        {
            int Yards = Inches / 36;        // calculates yards by dividing inches variable by 36
            int Feet = (Inches % 36) / 12;     // calculates remaining feet by using the % operand to divide inches by 36 and dividing the remainder by 12
            int Remainder = Inches % 12;    // calulates remaining inches by using the % operand and dividing inches by 12

            Console.WriteLine("{0} inches is equal to {1} yards {2} feet and {3} inches.", Inches, Yards, Feet, Remainder);
            // console display of the original variable and the conversions
        }
    }
}
