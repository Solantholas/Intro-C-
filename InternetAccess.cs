/*  Corey Hicks
    5 September 2017
    Business System Programming
    Assignment 7.2

        This winform application calls the Form1_Load method to instantiate messageboxes that utilize user pressed buttons to answer booleans.
    First, a partial class Form1 is instantiated with inheritance from the Form class. Second, a public constructor is used with a generic function
    to initialize the components of the Form class. Third, a generic Form loading method is used to inizialize Form class objects. Fourth, a yes/no
    messagebox is instantiated to ask the user if they want to purchase an internet plan. Fifth, a boolean determines if the user selected yes or no
    and the proper messagebox is displayed. Sixth, a third boolean is used to determine user response if the first response was yes. Finally, an OK
    message box is displayed to show the user which selection they made before terminating the application.*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetAccess
{
    public partial class Form1 : Form   // partial class that inherits properties from Form
    {
        public Form1()  // Form1 constructor with no arguments
        {
            InitializeComponent();  // generic function for initializing Form components
        }

        private void Form1_Load(object sender, EventArgs e) // generic method to initialize Form objects
        {
            string message =                                            // instantiates yes/no message box with custom message and caption
                "Do you want to purchase an internet service plan?";
            const string caption = "Internet Services";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);  // adds question mark icon to messagebox

            if (result == DialogResult.Yes) // boolean to determine if user selected yes to first messagebox
            {
                message =                                               // instantiates yes/no message box with custom message and caption
                    "Press Yes for Unlimited Access ($19.95) \nPress No for Limited Access ($10.95)";
                result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);  // adds question mark icon to messagebox

                if (result == DialogResult.Yes) // boolean to determine if user selected yes to second messagebox
                {
                    message =                                           // instantiates yes/no message box with custom message and caption
                        "Unlimited Access selected: $19.95 per month.";
                    result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK);
                    Application.Exit(); // terminates application
                }

                else // boolean to determine if user selected no to second messagebox
                {
                    message =                                           // instantiates yes/no message box with custom message and caption
                        "Limited Access selected: $10.95 per month.";
                    result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK);
                    Application.Exit(); // terminates application
                }
            }

            else // boolean to determine if user selected no to second messagebox
            {
                message =                                           // instantiates yes/no message box with custom message and caption
                        "No plan selected: $0.00 per month.";
                result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK);

                Application.Exit(); // terminates application
            }
        }
    }
}
