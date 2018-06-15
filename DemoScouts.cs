/*  Corey Hicks
    25 August 2017
    Business System Programming
    Assignment 5.2

        This program declares fields and constructors in the first class and instantiates that class in the second class with the appropriate overload signatures.
    First, all variables, and one constant variable, are declared as public fields within the GirlScout class. Second, 2 overloaded constructors are declared: one
    with default values, and one with parameter values. Third, a second class is initialized and invokes 2 GirlScout objects. The first object has values declared
    within the signature, and the second object utilizes values that were declared in the previous class. Fourth, control is passed to the Display method which is 
    used to invoke the GirlScout object and display each of the fields as an output before passing control back to the Main method. Finally, girlscoutMotto is 
    displayed by invoking the GirlScout object and the constant string contained in the GirlScout object.   */

using System;

namespace ConsoleApplication34
{
    class GirlScout
    {
        public string girlscoutName { get; set; }   // declares public string field with get, set property accessors
        public int troopNumber { get; set; }    // declares public int field with get, set property accessors
        public double duesOwed { get; set; }    // declares public double field with get, set property accessors

        public const string girlscoutMotto = ("\"to obey the Girl Scout law\"");    // declares public constant string without property accessors

        public GirlScout(string Name, int Number, double Dues)  // overloaded constructor that includes parameters in the signature
        {
            girlscoutName = Name;
            troopNumber = Number;
            duesOwed = Dues;
        }

        public GirlScout() : this("Ann", 103, 70.25)    // parameterless overloaded constructor with variables declarded in the signature
        {

        }
    }

    class DemoScouts
    {
        static void Main()
        {
            GirlScout First = new GirlScout("Becky", 103, 80.32);   // invokes the GirlScout object and passes 3 values to the constructor
            GirlScout Second = new GirlScout(); // invokes the GirlScout object using the constructor with preset values

            Display(First); // calls the Display method with the "First" GirlScout argument
            Display(Second);    // calls the Display method with the "Second" GirlScout argument

            Console.WriteLine();
            Console.WriteLine(GirlScout.girlscoutMotto);    // prints the Motto by referencing the GirlScout class name only
        }

        static void Display(GirlScout scout)    // initializes the Display method that passes in name, number, and dues
        {
            Console.WriteLine("{0, 10} {1, 10} {2, 10}", scout.girlscoutName, scout.troopNumber, scout.duesOwed.ToString("C2"));
        }
    }
}
