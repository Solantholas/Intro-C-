/*  Corey Gruhn-Hicks
    Assignment 8.1
    Intro to Programming Using C#

        This program first prompts the user to enter a string of at least 10 characters. Second, the program performs a boolean check on the length of the characters entered. If the characters entered
    are less than 10, the program will initiate a do-while loop that will continually prompt the user to enter a string of 10 characters. Once a minimum of 10 characters is reached, the loop breaks and
    performs 3 different changes to the entered string. First, the program displays the first 5 characters of the entered string. Second, the program replaces any and all spaces with asterisks. Finally,
    the program capitalizes any and all letters in the entered string.  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] compositeString = { "4for", "2is the", "3week 10 challenge assignment", "1This assignment", "5CIS243" };

            for (int Count = 0; Count < compositeString.Length; Count ++)
            {
                string String(Count) = compositeString[Count];
            }
        }
    }
}
