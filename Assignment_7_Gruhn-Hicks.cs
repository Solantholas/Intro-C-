/*  Corey Gruhn-Hicks
    Assignment 7.1
    Intro to Programming Using C#

        This program runs uses 2 for loops to gather random numbers and user input numbers respectively. A getRandom method is used to call an instance of the Random class and limits the random value to a number between 1, and 100.
    An overloaded method (Calculate) is used with 2 different signatures to calculate the average of the random loop and a total of the user input loop. Both the random average and user input total are displayed.    */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_Gruhn_Hicks
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomValue = 0;
            double Average = 0;
            double Total = 0;
            double Input = 0;
            int Seed = 0;

            for (int count = 0; count < 20; count++)    // begins the for loop starting at 0 and ending at 19 for a total of 20 passes
            {
                Seed = (int)DateTime.Now.TimeOfDay.Ticks;   // assigns int Seed with the number of TimeOfDay ticks
                randomValue += getRandom(Seed);     // assigns randomValue with a random number "seeded" by the seed int
            }

            Calculate(randomValue, ref Average);    // calls the overloaded Calculate method to calculate the average of the 20 random numbers

            Console.WriteLine("The average of the 20 random numbers is: " + Average); // displays the average of the 20 random numbers
            Console.WriteLine();

            for (int count = 1; count <= 5; count++)    // begins the for loop starting at 1 and ending at 5 for a total of 5 passes
            {
                Console.Write("Enter a double value: ");    // prompts the user to enter a double
                Input = Convert.ToDouble(Console.ReadLine());   // converts the entered number to a double and assigns the double to Input

                Calculate(Input, ref Total);    // calls the overloaded Calculate method to calculate the total value of each user input as the loop passes
            }

            Console.WriteLine("The total is: " + Total);    // displays the total value of the 5 user input doubles
        }

        static int getRandom(int Seed)  // creates the method getRandom with an int Seed signature
        {
            Random myRandom = new Random(); // calls the random class and assigns the class to myRandom
            int randomNumber = myRandom.Next(1, 100);   // instantiates the integer randomNumber and assigns it a value of myRandom with a limit of 1, and 100.

            return randomNumber;    // returns the value of randomNumber
        }

        static void Calculate(int randomValue, ref double Average)  // creates the method Calculate with an int and ref double signature
        {
            Average = randomValue / 20;  // assigns double average the value of randomValue divided by 20
        }

        static void Calculate(double Input, ref double Total)   // overloads the method Calculate with a double and ref double signature
        {
            Total = Total + Input;  // assigns the double total with double input plus double total
        }
    }
}

/*  Develop a C# console application that will implement one method that will return an integer value, one void method that will calculate an average, and one 
 * void overload for the calculate method that will compute a total.  Please read the requirements below carefully.

In Main:

    You will need four variables:  an integer value to hold a random value, a double value to hold an average, a double value to hold a total, and a double value 
 * to hold an input entry. Using a for loop that will call a getRandom method 20 times.  In the loop you will pass a seed value to the getRandom method to use with 
 * the random generator and it will return a random value to be added to (accumulate) to the local integer variable in Main.  In the getRandom method you will 
 * generate a random value between 1 and 100  (see p241, section 7.9) and return that random value to Main.  The random value will be generated in getRandom using 
 * a Random class object. Once the loop has completed the 20 method calls you will call a calculate method which returns no value and to which you will pass the 
 * total of the random values, the  average variable  by reference, and the literal value of 20.  In the calculate method you will compute and average by dividing 
 * the total of the random number passed in by the literal value 20 that was passed into the calculate method. After the calculate method executes you will display 
 * the average to the console. Following the writeline statement noted above, you will implement a second for loop that will process 5 iterations.  Within this for 
 * loop you will prompt the user to enter a double value from the console and then assign that input to the double variable declared to hold the input entry.  Also 
 * within the loop you will call an overload of the void calculate method and will pass two arguments:  the entry taken from the console and the variable to hold 
 * the total by reference.  The overload of the void calculate method will receive the double entry value and the byref double variable that will receive the total.
 * In the overloaded calculate method you will add the value passed in to the total variable. After the overloaded calculate method executes you will display the 
 * total to the console.

In summary:

    You will have Main in which you will declare 4 variables, a loop that will call a method that will return a random number, a call to a void calculate method 
 * which will take an integer random value variable, a byref average variable, a literal value of 20 as arguments and which will calculate an average, followed by 
 * a console writeline to display the average.  This will be followed by a loop that will execute 5 times and will prompt for and assign a double value to a double 
 * variable and then call an overload of the calculate method and pass the entered value and a byref total variable.  In the overloaded calculate method you will 
 * accumulate the passed value into the total variable.  After the loop you will display the total.

The output might look similar to this:

The average of the 20 random numbers is 71

Enter a double value 11.11
Enter a double value 22.22
Enter a double value 33.33
Enter a double value 44.44
Enter a double value 55.55
The total is 166.65
Press any key to continue . . . */
