/*  Corey Hicks
    5 September 2017
    Business System Programming
    Assignment 7.2

        This windows form program uses a simple form with a single button to display a copyright messagebox. First, the form is displayed
    to the user with properties assigned to the name of the form and button. Second, once the button is clicked, a private method is called
    that displays an ok messagebox with copyright info displayed in the message. Third, the message box is closed and the user may click the
    button again, minimize the form, or close the form by clicking the X on the upper, right-hand side. */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication9
{
    public partial class Copyright : Form
    {
        public Copyright()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message =                                            // instantiates ok message box with custom message and caption
                "Copyright © 2017 by Corey Hicks";
            const string caption = "Copyright";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK);
        }
    }
}
