/*  Corey Gruhn-Hicks
    Assignment 4.1
    Intro to Programming Using C#
 
    This program incorporates a "while" loop and "if" statements to determine a salesmans' earnings based on sales commission. During the "while" loop
    the program assigns a number to ProductCount. Depending on which number is assigned to ProductCount the program will determine which "if" statement
    will be used in calculation. Each "if" statement prompts the user to to enter a value for number of products sold. After all 4 product sales values
    are entered into the program it will calculate commission rate multiplied by all 4 products and add weekly wage.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_Gruhn_Hicks
{
    class Program
    {
        static void Main(string[] args)
        {
            double GrossSales = 0; // declares GrossSales as a double equal to zero.
            double ProductCount = 0; // declares Product count as a double equal to zero.

            while (ProductCount < 4) // begins "while" loop while product count is between 0 and 3.
            {

                if (ProductCount == 0) // begins "if" statement while ProductCount is 0.
                {
                    Console.Write("Enter number sold of product #1. "); // Prompts the user to enter value for Product 1.
                    double Product1 = Convert.ToDouble(Console.ReadLine()); // Assigns Product1 equal to the user entered value.

                    Product1 = Product1 * 239.99; // Computes the user entered value multiplied by 239.99.

                    GrossSales = GrossSales + Product1; // Adds the completed computation of Product1 to GrossSales.
                }

                if (ProductCount == 1)
                {
                    Console.Write("Enter number sold of product #2. ");
                    double Product2 = Convert.ToDouble(Console.ReadLine());

                    Product2 = Product2 * 129.75;

                    GrossSales = GrossSales + Product2; // Adds the completed computation of Product2 to GrossSales.
                }

                if (ProductCount == 2)
                {
                    Console.Write("Enter number sold of product #3. ");
                    double Product3 = Convert.ToDouble(Console.ReadLine());

                    Product3 = Product3 * 99.95;

                    GrossSales = GrossSales + Product3; // Adds the completed computation of Product3 to GrossSales.
                }

                if (ProductCount == 3)
                {
                    Console.Write("Enter number sold of product #4. ");
                    double Product4 = Convert.ToDouble(Console.ReadLine());

                    Product4 = Product4 * 350.89; // Adds the completed computation of Product4 to GrossSales.

                    GrossSales = GrossSales + Product4;
                }

                ProductCount++; // Assigns ProductCount to 1 number greater than it was before. Continues the loop untile ProductCount == 4
            }

            double earnings = 200 + (GrossSales * .09); // Declares earnings as a double equal to 200 plus 9% of total gross sales.
            earnings = Math.Round(earnings, 2); // rounds the earnings to 2 decimal places.

            Console.WriteLine("Earnings this week: ${0}", earnings); // Displays the total earnings to the user.


        }
    }
}

/* initialize gross sales to zero

initialize the product count to zero

while product count is less than four

    increment the product count

    input the number of items sold

    determine the cost per item based on the product count

    calculate the product’s sales by multiplying the number of items sold

    by the cost per item

    add the product’l s sales to gross sales

end while

calculate the salesperson’s earnings as $200 plus 9% of gross sales

output the salesperson’s earnings
 
 Develop a C# console application that will take inputs for a salesperson. The 4 inputs will be for the salesperson’s items sold for the previous week 
 and calculates and displays that salesperson's earnings. There is no limit to the number of items that can be sold by a salesperson. Use a while loop 
 to implement the inputs and calculations.

 The company pays its salespeople on a commission basis. The salespeople receive $200 per week plus 9% of their gross sales for that week. For example, 
 a salesperson who sells $5,000 worth of merchandise in a week receives $200 plus 9% of $5,000, or a total of $650. You’ve been supplied with a list of 
 items that can be sold by a salesperson. The values of these items are as follows:

    Item Value
    1 239.99
    2 129.75
    3 99.95
    4 350.89
*/
