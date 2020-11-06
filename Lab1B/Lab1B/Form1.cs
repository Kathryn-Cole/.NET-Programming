using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1B
{
    public partial class Form1 : Form
    {
        //initializing contants for the prices of the tickets as integers
        const int classA = 15;
        const int classB = 12;
        const int classC = 9;

        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        { 
            try
            {
                //taking the numbers in Classes A-C on the form
                decimal valueA = Convert.ToDecimal(txtClassA.Text);
                decimal valueB = Convert.ToDecimal(txtClassB.Text);
                decimal valueC = Convert.ToDecimal(txtClassC.Text);

                //calculating each class types revenue by taking the ticket prices (constants) and multiplying 
                        //them by the number of tickets sold in the input
                decimal revenueClassA = valueA * classA;
                decimal revenueClassB = valueB * classB;
                decimal revenueClassC = valueC * classC;

                //Outputting the results in the read-only text boxes
                totalClassA.Text = revenueClassA.ToString("c");
                totalClassB.Text = revenueClassB.ToString("c");
                totalClassC.Text = revenueClassC.ToString("c");

                //calculating the total revenue from all the tickets by adding them together
                decimal grandTotalRevenue = revenueClassA + revenueClassB + revenueClassC;
                //outputting the result in the read-only textbox
                totalRevenue.Text = grandTotalRevenue.ToString("c");
            }
            //catching exceptions
            catch (Exception ex)
            {
                //will display an error for incorrectly formatted numbers
                if (ex is FormatException || ex is OverflowException)
                {
                    MessageBox.Show("You have entered an invalid number. Only enter whole numbers into the text feilds", "Invalid Entry");
                }
                //will tell you what's wrong if it's not format exception for overflow exception
                else
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Error!");
                }
            }

        }
        //clears the textboxes when you click the "clear" button
        private void Clear_Click(object sender, EventArgs e)
        {
            txtClassA.Text = "";
            txtClassB.Text = "";
            txtClassC.Text = "";
            totalClassA.Text = "";
            totalClassB.Text = "";
            totalClassC.Text = "";
            totalRevenue.Text = "";
        }
        //exits the proogram when you click "exit"
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
