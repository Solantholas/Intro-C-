
/*  Corey Gruhn-Hicks
    Intro to Production Using C#
    Assignment 2.1
    average class with automatic properties for the variable1, variable2, and variable3.*/
using System;

public class average
{
    //You do not have to implement the automatic properties, use these.
    //
    // auto-implemented property Score1 implicitly creates an
    // instance variable for the score1
    public int Variable1 { get; set; }

    // auto-implemented property Score2 implicitly creates an
    // instance variable for the score2
    public int Variable2 { get; set; }

    // auto-implemented property Score3 implicitly creates an
    // instance variable for the score3
    public int Variable3 { get; set; }

    //declare the remainder and avg variables (use these)
    int remainder;
    int avg;

    // constructor shell accepting three values, you fill in the 
    //rest of the code
    public average(int variable1Value, int variable2Value, int variable3Value)
    {
        //write code here to set each class instance variable to the
        //values you passed to the constructor (average)
        Variable1 = variable1Value;
        Variable2 = variable2Value;
        Variable3 = variable3Value;
    } // end three-parameter constructor

    // calculate the average of the three scores
    public void computeAverage()
    {
        avg = (Variable1 + Variable2 + Variable3) / 3;
        remainder = (Variable1 + Variable2 + Variable3) % 3;

    } // end method computeAverage




    // display the average, you fill in the rest of the code
    public void DisplayAverage()
    {
        //Write the console writeline to output the three variables,
        //the average and the remainder to the console
        Console.WriteLine("The average of {0}, {1}, and {2} is {3} with a remainder of {4}.", Variable1, Variable2, Variable3, avg, remainder);
    } // end method DisplayAverage 
} // end class average

public class averageTest
{
    public static void Main(string[] args)
    {
        //instantiate a new average object here, passing the
        //the score1, score2 and score3 values respectively 

        average avg1 = new average(3, 6, 4);

        avg1.computeAverage();
        avg1.DisplayAverage();

        Console.WriteLine(); // output a new line
    } // end Main
} // end class averageTest
