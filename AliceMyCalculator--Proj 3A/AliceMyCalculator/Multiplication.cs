using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public class LessThanZeroException : Exception
{
    public LessThanZeroException()
    { }
    public LessThanZeroException(string message)
        : base(message)
    { }
    public LessThanZeroException(string message, Exception inner)
        : base(message, inner)
    { }
}

namespace AliceMyCalculator
{
    public partial class Multiplication : Form
    {
        public Multiplication()
        {
            InitializeComponent();
        }

       private void Multiply_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Int32.MaxValue;
                bool res1 = Double.TryParse(txtNumber1.Text, out x);
                if (x > Int32.MaxValue || x < Int32.MinValue)
                    throw new OverflowException("Number1 must be lesser than Max.Value");

                double y = Int32.MaxValue;
                bool res2 = Double.TryParse(txtNumber2.Text, out y);
                if (y > Int32.MaxValue || y < Int32.MinValue)
                    throw new OverflowException("Number2 must be lesser than Max.Value");
            }
            catch (OverflowException)
            {
                MessageBox.Show("A OverflowException has occurred." + "\n\n"
                    + "Please entering a number between -2,147,483,648 and 2,147,483,647.", "Entry Error");
                return;
            }
            int Number1 = Convert.ToInt32(txtNumber1.Text);
            int Number2 = Convert.ToInt32(txtNumber2.Text);
            int Result1;

            Result1 = Number1 * Number2;

            txtNumber1.Text = Number1.ToString();
            txtNumber2.Text = Number2.ToString();
            txtResult1.Text = Result1.ToString();
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal x = 0m;
                bool res = Decimal.TryParse(txtNumber1.Text, out x);
                if (res == false)
                    throw new FormatException("Number1 must be number");
                if (x <= 0m)
                    throw new LessThanZeroException("Number1 must be greater than zero");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + "\n\n"
                    + ex.GetType().ToString() + "\n\n"
                    + "Please enter a number for the Number1 field", "Entry Error");
                return;
            }
            catch (LessThanZeroException)
            {
                MessageBox.Show("A LessThanZeroException has occurred." + "\n\n"
                    + "Please entering a number greater than zero.", "Entry Error");
                return;
            }


            try
            {
                decimal x = 0m;
                bool res = Decimal.TryParse(txtNumber2.Text, out x);
                if (res == false)
                    throw new FormatException("Number2 must be number");
                if (x == 0m)
                    throw new DivideByZeroException("Number2 can not be zero");
                if (x <= 0m)
                    throw new LessThanZeroException("Number2 must be greater than zero");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + "\n\n"
                    + ex.GetType().ToString() + "\n\n"
                    + "Please enter a number for the Number2 field", "Entry Error");
                return;
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("A DivideByZeroException has occurred." + "\n\n"
                    + "Please entering a number is not zero.", "Entry Error");
                return;  
            }
            catch(LessThanZeroException)
            {
                MessageBox.Show("A LessThanZeroException has occurred." + "\n\n"
                    + "Please entering a number greater than zero.", "Entry Error");
                return;
            }


            decimal Number1 = Convert.ToDecimal(txtNumber1.Text);
            decimal Number2 = Convert.ToDecimal(txtNumber2.Text);
            decimal Result2;

            Result2 = Number1 / Number2;

            txtNumber1.Text = Number1.ToString();
            txtNumber2.Text = Number2.ToString();
            txtResult2.Text = Result2.ToString();
        }
    }
}
