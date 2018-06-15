using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Prices = new double[10];

            for (int Count = 0; Count < Prices.Length; Count++)
            {
                Console.Write("Enter price {0}: ", Count + 1);
                Prices[Count] = Convert.ToDouble(Console.ReadLine());
            }

            double Sum = Prices.Sum();

            Console.WriteLine("The sum of the values entered is: " + Sum.ToString("C2"));

            Console.Write("Prices less than $5.00 : ");

            for (int Count = 0; Count < Prices.Length; Count++)
            {
                if (Prices[Count] < 5.00)
                {
                    Console.Write(Prices[Count].ToString("C2") + " ");
                }
            }

            Console.WriteLine();

            double Average = Prices.Sum() / Prices.Length;

            Console.Write("Prices higher than the average {0}: ", Average.ToString("C2"));

            for (int Count = 0; Count < Prices.Length; Count++)
            {
                if (Prices[Count] > Average)
                {
                    Console.Write(Prices[Count].ToString("C2") + " ");
                }
            }

            Console.WriteLine();
        }
    }
}

/*

    Create a console program where you will implement variables that are needed for this program and will implement the code within Main.

    Create an array that stores 10 prices.

    Prompt the user to enter the 10 values as currency.

    Access the array elements and display a sum of the 10 values.

    Display all of the entered values less than $5.00.

    Calculate the average of the 10 values.

    Display the average of the entered values and the entered values higher than the average.

You should format your output to look something like the following:

This will require some analysis of the problem before coding is accomplished.

 

Enter price 1  1.11

Enter price 2  2.22

Enter price 3  3.33

Enter price 4  4.44

Enter price 5  5.55

Enter price 6  6.66

Enter price 7  7.77

Enter price 8  8.88

Enter price 9  9.99

Enter price 10  10.10

 

The sum of the values entered is: $60.05

Prices less than $5.00:$1.11 $2.22 $3.33 $4.44

Prices higher than average $6.01$6.66 $7.77 $8.88 $9.99 $10.10

Press any key to continue . . .*/
