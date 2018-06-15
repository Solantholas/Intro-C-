/*  Corey Gruhn-Hicks
    Assignment 12.1
    Intro to Programming Using C#

        This program utilizes 2 classes and 3 private variables for computation. These private variables are manipulated with get/set methods to allow public manipulation.
    Two additional methods are used to calculate gross pay adjustment and printing the variables. In main the private variables are manipulated with public values and methods
    for calculation and printing are called.    */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First name: ");    // prompts the user to enter a first name
            string first = Convert.ToString(Console.ReadLine());

            Console.Write("Enter the Last name: "); // promptes the user to enter a last name
            string last = Convert.ToString(Console.ReadLine());

            Console.Write("Enter the raw pay: ");   // prompts the user to enter gross pay
            double gross = Convert.ToDouble(Console.ReadLine());

            myPayfile Person = new myPayfile(); // instantiates object of myPayfile type
            Person.getFirst_Name = first;   // set private class variable with public properties
            Person.getLast_Name = last;     // set private class variable with public properties
            Person.getGross_Pay = gross;    // set private class variable with public properties
            Person.adjustPay(); //call public class object method
            Person.printit();   //call public class object method
        }
    }

    class myPayfile
        {

        private string last_name;   //declare the class variables
        private string first_name;
        private double gross_pay;
        
        public myPayfile()  //no argument constructor (not used)
        {
        }

        public myPayfile(string fname, string lname, double pay)    //three-argument constructor to set the values input to the console
        {
            lname = last_name;
            fname = first_name;
            pay = gross_pay;
        }

        public string getLast_Name  //public class method to return the individual value
        {
            get //used to retrieve the contents of the private class variable
            {
                return last_name;
            }
            set //used to set the value of the private class variable
            {
                last_name = value;
            }
        }

        public string getFirst_Name //public class method to return the individual value
        {
            get //used to retrieve the contents of the private class variable
            {
                return first_name;
            }
            set //used to set the value of the private class variable
            {
                first_name = value;
            }
        }

        public double getGross_Pay  //public class method to return the individual value
        {
            get //used to retrieve the contents of the private class variable
            {
                return gross_pay;
            }
            set //used to set the value of the private class variable
            {
                gross_pay = value;
            }
        }

        public void adjustPay() //public class method to recompute the pay value
        {
            gross_pay = (gross_pay * 1.2);    //adjust the pay by multiplying it by a factor of 1.2
        }

        public void printit()  //public class method to display results
        {
            Console.WriteLine("The adjusted pay is {0:C2} for {1} {2}.", getGross_Pay, getFirst_Name, getLast_Name);
        }

    }
}

    /*
    Write the code in main to declare any needed local variables, take entries for the first name, last name and raw pay. 
    Create a myPayfile object, passing as arguments to the constructor the first name, last name and raw pay entered from
    the console.  Call the adjustPay class method.  Display the class object data to the console. 
    */

