/*  Corey Hicks
    3 September 2017
    Business System Programming
    Assignment 6.2

        This program declares fields in 3 different classes and uses a 4th class to display the fields. First, a dimensions class is instantiated
     with 2 integer fields. A ToString() override method is used to convert the integer fields to string values. Second, a VideoCassetteTape class
     is declared with a playtime field. This field uses a boolean equation to determine if the value of the playtime field is between 0 and 180.
     Third, an AdhesiveTape class is declared with a stickiness field. This field uses a boolean equation to determine if the value of the stickiness
     field is between 0 and 10. Finally, all 3 classes are called in the Program class to display values for all the assigned fields in the previous
     classes.   */

using System;

namespace ConsoleApplication36
{
    class Dimensions    // instantiates the first class
    {
        public int tapeLength { get; set; } // declares field with get, set accessors
        public int tapeWidth { get; set; }

        public Dimensions(int Length, int Width)    // constructor with 2 int inputs
        {
            tapeLength = Length;
            tapeWidth = Width; 
        }

        public override string ToString()   // override method to convert integers to strings
        {
            return string.Format("[{0}, {1}]", tapeLength, tapeWidth);
        }
    }


    class VideoCassetteTape // instantiates the second class
    {
        private int playtime { get; set; }  // declares private field with get, set accessors

        public int playTime // public playtime field that retrieves private field and sets a value only after a boolean equation
        {
            get
            {
                return playtime;
            }
            set
            {
                int MINIMUM = 0;
                int MAXIMUM = 180;
                if (value < MINIMUM)
                    playtime = MINIMUM;
                else if (value > MAXIMUM)
                    playtime = MAXIMUM;
                else
                    playtime = value;
            }
        }
    }

    class AdhesiveTape  // instantiates the third class
    {
        private int stickiness { get; set; }    // declares private field with get, set accessors

        public int Stickiness   // public stickiness field that retrieves private field and sets a value only after a boolean equation
        {
            get
            {
                return stickiness;
            }
            set
            {
                int MINIMUM = 0;
                int MAXIMUM = 10;
                if (value < MINIMUM)
                    stickiness = MINIMUM;
                else if (value > MAXIMUM)
                    stickiness = MAXIMUM;
                else
                    stickiness = value;
            }
        }

        class Program   // instantiates the fourth class with main method
        {
            static void Main()
            {
                Dimensions myDimensions = new Dimensions(10, 15);   // calls the dimensions method with variables declared in the signature
                VideoCassetteTape myVideoCassetteTape = new VideoCassetteTape();    // calls the videocassettetape class
                AdhesiveTape myAdhesiveTape = new AdhesiveTape();   // calls the myadhesivetape class

                myVideoCassetteTape.playTime = 400; // assigns 400 to playtime method
                myAdhesiveTape.Stickiness = -20;    // assigns -20 to stickiness method

                Console.WriteLine("Dimensions are: {0}.", myDimensions);
                Console.WriteLine("Play time is: {0}.", myVideoCassetteTape.playTime);
                Console.WriteLine("Stickiness is: {0}.", myAdhesiveTape.Stickiness);
            }
        }
    }
}
