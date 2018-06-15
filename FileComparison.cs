/*  Corey Hicks
    23 September 2017
    Business System Programming
    Assignment 9.3

        This console application accesses the bytesize of 2 files, displays them, and calculates the ratio of each file. First, the program
    assigns the filepath of both files as a string variable. Second, the FileInfo class is used to access the specified filepath and assign
    the length property of the file as a long variable. Third, the bytesize of both files is compared against one another to determine the
    ratio of the file. Finally, the bytesize of each file is displayed and the ratio of each file is displayed as a percentage. */

using System;
using System.IO;    // using statement for System.IO so it does not have to be declared before FileInfo
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\kolen\Desktop\Business System Programing\Quote.txt";
            // assigns filepath as a string
            string path2 = @"C:\Users\kolen\Desktop\Business System Programing\Quote.docx";

            long noteInfo = new FileInfo(path1).Length;
            // uses FileInfo class to retrieve the filepath of the path1 string and access the bytesize of the specified file
            long wordInfo = new FileInfo(path2).Length;

            decimal noteRatio = (decimal) noteInfo / (noteInfo + wordInfo);
            // calculates the ratio of the file bytesize compared to both files
            decimal wordRatio = (decimal)wordInfo / (noteInfo + wordInfo);

            Console.WriteLine("The bytesize of the Notepad file is: {0} and the ratio of the Notepad file is: {1:P}.", noteInfo, noteRatio);
            // displays the bytesize and ratio of the file. Ratio is displayed as a percentage to the nearest 100th
            Console.WriteLine("The bytesize of the Word file is: {0} and the ratio of the Word file is: {1:P}.", wordInfo, wordRatio);
        }
    }
}
