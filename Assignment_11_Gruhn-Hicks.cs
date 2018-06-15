/*  Corey Gruhn-Hicks
    Assignment 11.1
    Intro to Programming Using C#

        This program references two arrays and displays the results with the append method from the string builder class. First, the program initializes 2 arrays: Apartment and Rent.
    Second, the program prompts the user to enter an Apartment number. Third, the program calls the getRent method: passing arrays by reference, and user input as signatures. Fourth,
    getRent uses a for loop and a boolean to determine which user input number matches which Apartment array number matches. Fifth, the program calls the printit method within the for
    loop of the getRent method. Finally, the printit method calls the stringbuilder class and append methods to build the final sentence of the program.    */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Apartment = new int[5] { 123, 204, 601, 609, 612 };   // initializes Apartment array with values added to each element
            int[] Rent = new int[5] { 500, 750, 495, 800, 940 };    // initializes Rent array with values added to each element

            Console.Write("Enter the apartment number: ");  // prompts the user to enter an apartment number
            int apartmentNumber = Convert.ToInt32(Console.ReadLine());

            getRent(ref Apartment, ref Rent, apartmentNumber);  // calls the getRent method passing Apartment, Rent, and apartmentNumber

        }

        static void getRent (ref int[] Apartment, ref int[] Rent, int apartmentNumber)  // initializes getRent method with signature
        {
            for(int Count = 0; Count < 5; Count++)  // initializes for loop with 5 passes
            {
                if (Apartment[Count] == apartmentNumber)    // boolean check if Apartment[Count] is equal to apartmentNumber
                {
                    printit(ref Apartment[Count], ref Rent[Count]); // calls printit method passing Apartment and Rent
                }
            }
        }

        static void printit (ref int Apartment, ref int Rent)   // initializes printit method with signature
        {
            StringBuilder Sentence = new StringBuilder();   // calls new instance of stringbuilder class.

            Sentence.Append("Rent for the Apartment #");    // calls append method 4 times to build final sentence of program
            Sentence.Append(Apartment);
            Sentence.Append(" is $");
            Sentence.Append(Rent);

            Console.WriteLine(Sentence);    // displays stringbuilder Sentence
        }
    }
}

/*

Develop a C# console application that implements two parallel int arrays in Main, one called apartment and the other called rent. Each array will hold 5 integer values.  Use an initializer to fill 
the apartment array with the values  {123, 204, 601, 609, 612}.  Use an initializer to fill the rent array with the values {500, 750, 495, 800, 940}. 

Create two static methods, one called getRent and one called printit.  When the getRent method is called from Main you should pass the apartment array by reference, the rent array by reference and 
the apartment number console entry.

In the getRent method you should use a for loop to match apartment number passed to the method and match it to the apartment numbers in the apartment array that was passed to the getRent.  When a 
match is found in the apartment number array call the printit method from the getRent method and pass by value the apartment number and the matching rent value from the rent array to the printit method.

In the printit method print the apartment number and the rent for that apartment to the console as shown in the output example below.  When you print the output, instead of using a string concatenation 
(Console.WriteLine("Rent for apartment # " + choice + " is $" + rent);) use a StringBuilder object. The string parts of the message ("Rent for apartment #" and " is $") should be declared as separate strings. 
Using the StringBuilder object methods, you will append the two strings and two integer values together and write the final appended output to the console. The appends and output should all be done in the print method.

Enter the apartment number 601
Rent for apartment # 601 is $495
Press any key to continue . . .

*/
