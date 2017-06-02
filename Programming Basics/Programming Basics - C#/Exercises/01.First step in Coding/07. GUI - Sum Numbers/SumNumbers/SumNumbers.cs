using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumNumbers
{
    public partial class SumNumbers : Form
    {
        public SumNumbers()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Kakvo shte se sluchi pri natiskane na buttona?
            try
            {
                decimal number1 = decimal.Parse(this.textBox1.Text);
                decimal number2 = decimal.Parse(this.textBox2.Text);
                decimal sum = number1 + number2;

                textBoxSum.Text = sum.ToString();
            }
            catch(Exception)
            {
                textBoxSum.Text = "ERROR";
            }
        }
    }
}
