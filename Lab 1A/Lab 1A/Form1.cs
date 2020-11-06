using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //calculating to Farhrenheit
        private void button1_Click(object sender, EventArgs e)
        {
        //try/catch statement to catch exceptions
            try
            {
                //taking input and holding it in a variable
                decimal Celcius = Convert.ToDecimal(temperature.Text);
                //calculating to farhrenheit and putting it in it's own variable
                decimal Farhrenheit = (9 / 5) * Celcius + 32;
                //displaying answer in the read-only text box
                answer.Text = Farhrenheit.ToString("g2");
                answer.Focus();
            }
            //catching exceptions
            //to save typing, I just added one catch that would check for all excpetions
            catch (Exception ex)
            {
                //if it's not a number or the number is too big, it tells the user to input something else
                if (ex is FormatException || ex is OverflowException)
                {
                    MessageBox.Show("You have entered an invalid number.", "Invalid Entry");
                }
                //otherwise it tells you exactly whats going on
                else
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Error!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //same as when we calculted to farhrenheit, taking input and adding it to a variable
                decimal Farhrenheit = Convert.ToDecimal(temperature.Text);
                //calculating Celcius and storing it in a variable
                decimal Celcius = (9 / 5) * (Farhrenheit - 32);
                //putting the answer into the read-only text box
                answer.Text = Celcius.ToString("g2");
                answer.Focus();
            }
            catch (Exception ex)
            {
                //if it's not a number or the number is too big, it tells the user to input something else
                if (ex is FormatException || ex is OverflowException)
                {
                    MessageBox.Show("You have entered an invalid number.", "Invalid Entry");
                }
                //otherwise it tells you exactly whats going on
                else
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Error!");
                }
            }
        }
        //closes the program when you click the exit button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //when you type new numbers it clears the read only box
        private void ClearAnswer(object sender, EventArgs e)
        {
            answer.Text = "";
        }
    }
}
