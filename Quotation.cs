/*  Corey Hicks
    26 July 2017
    Business System Programming
    Assignment 1.2

        This is a simple console application that displays one of my favorite quotes by Muhammad Ali. This program only calls the WriteLine method to display 5 string lines and
    one blank line between the quote and the author. There are no other steps to this program.  */

using System;

namespace Quotation
{
    class Program   // main clas of the program
    {
        static void Main(string[] args) // main method of the program
        {
            Console.WriteLine("\"I don't count my sit-ups.");   // calls the writeline method to display the first string line. \" is used to insert an imbedded quotation mark (Microsoft, 2017).
            Console.WriteLine("I only start counting when it starts hurting."); // calls the writeline method to display the second string line.
            Console.WriteLine("That is when I start counting, because then it really counts."); // calls the writeline method to display the third string line.
            Console.WriteLine("That's what makes you a champion.\"");   // calls the writeline method to display the fourth string line. \" is used to insert an imbedded quotation mark.
            Console.WriteLine();    // calls the writeline method to display a blank string line.
            Console.WriteLine(" - Muhammad Ali");   // calls the writeline method to display the fifth string line.
        }
    }
}

/*  Reference

    Microsoft, (2017). Putting Quotation Marks in a String Programmatically (Windows Forms). Retrieved from https://msdn.microsoft.com/en-us/library/aa983682(v=vs.71).aspx */
