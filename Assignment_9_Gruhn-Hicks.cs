/*  Corey Gruhn-Hicks
    Assignment 8.1
    Intro to Programming Using C#

        This program implements 2 parallel arrays and 2 methods to provide user input to change the values of an array. First, the 2 arrays an initialized and values are added to the arrays. Second, a method is called to
    display the values within both arrays. Third, the program prompts the user to enter a price cutoff point and a price change by percentage. Fourth, the program calls a method that changed the values of the first array
    based on user input. Finally, the program displays both arrays again with the changes made to the first array. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] item_price = new double[5] {15.50, 50.99, 25.00, 115.49, 75.25};   // initializes the first array with values added to each element of the array
            string[] item_name = new string[5] {"Widget", "Thingy", "Ratchet", "Clanger", "Fracker"};   // initializes the second array with values added to each element of the array

            printit(item_price, item_name); // calls the printit method to display the values of both arrays

            Console.WriteLine();

            Console.Write("Enter the price cutoff point (eg $15.00): $");   // prompts the user to enter a price cutoff point
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the percentage price change (eg 0.25): "); // prompts the user to enter a percentage of price change
            double multiplier = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            changePrices(ref item_price, ref price, ref multiplier);    // calls the changePrices method passing item_price, price, and multiplier by reference

            printit(item_price, item_name);

        }

        static void printit(double[] item_price, string[] item_name)    // creates the method printit with item_price and item_name as the signature
        {
            for (int count = 0; count < 5; count++) // initializes a for loop with 5 passes for each element within the arrays
            {
                Console.WriteLine("The price for item {0} is {1}", item_name[count], item_price[count].ToString("C2")); // displays the values of both arrays
            }
        }

        static void changePrices(ref double[] item_price, ref double price, ref double multiplier)  // creates the method changePrices passing item_price, price, and multiplier by reference
        {
            for (int count = 0; count < 5; count++) // initializes a for loop with 5 passes for each element within the first array
            {
                if (item_price[count] <= price) // boolean that performs calculations if true
                {
                    item_price[count] = (item_price[count] * multiplier) + item_price[count];   // multiplies the element of the array by the price and adds the changes to the element of the array
                }

                else if (item_price[count] > price) // bolean that performs calculations if first boolean is false
                {
                    item_price[count] = item_price[count];  // assigns element back to array
                }
            }
        }
    }
}
