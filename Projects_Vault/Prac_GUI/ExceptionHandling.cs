using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac_GUI
{
    public partial class ExceptionHandling : Form
    {
        public ExceptionHandling()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Welcome to Windows Application");
            DialogResult dr = MessageBox.Show("Are yo sure to close this form?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //button1.Text = "Click Me...";
            button1.Text = "Close Form";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = checkBox1.Checked;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(textBox4.Text);
                float num2 = float.Parse(textBox3.Text);

                if (num1 == 0)
                    throw new MyCustomException("Number cannot be zero");//Custom exception reference

                if (num2 == 0)
                    throw new DivideByZeroException();
                float result = num1 / num2;
                label7.Text = result.ToString();
            }
            catch (DivideByZeroException)
            {
                label7.Text = "Cannot divide by zeo";
            }
            catch (FormatException)
            {
                //label7.Text = "Please enter only decimal numbers";
                label7.Text = "Please enter only numbers";
            }
            catch (Exception ex)
            {
                label7.Text = ex.GetType() + " : " + ex.Message;
            }
            finally
            {

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
