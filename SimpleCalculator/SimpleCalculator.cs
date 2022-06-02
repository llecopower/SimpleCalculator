using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you Sure that you want exit?", "Confirmation", 
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            { 
                 Application.Exit();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //simple basic validation
            if (textBox1Number1.Text == "")
            {

                //HOMEWORK NOT ALLOW TEXTBOX2 ACCEPT EMPTY  IF STETAMENT
                MessageBox.Show("Number 1 is required", "Missing value");
                textBox1Number1.Focus();
            }
            else
            { 
                labelResult.Text = "The Sum is: " + (Convert.ToInt32(textBox1Number1.Text) + 
                                                     Convert.ToInt32(textBoxNumber2.Text));           
            }

           
        }

        private void buttonSubstraction_Click(object sender, EventArgs e)
        {
            //simple basic validation
            if (textBox1Number1.Text == "")

            {
                //HOMEWORK NOT ALLOW TEXTBOX2 ACCEPT EMPTY  IF STETAMENT

                MessageBox.Show("Number 1 is required", "Missing value");
                textBox1Number1.Focus();
            }
            else
            {
                //HOMEWORK NOT ALLOW NEGATIVE NUMBER TIP IF STETAMENT

                MessageBox.Show("The Difference is: " + (Convert.ToInt32(textBox1Number1.Text) -
                                                         Convert.ToInt32(textBoxNumber2.Text)), "Difference") ;
            }
        }
    }
}
