using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3C_Math_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
                
        private void radioAdd_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioSubtract_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioMultiply_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioDivide_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Value1_Click(object sender, EventArgs e)
        {

        }

        private void Value2_Click(object sender, EventArgs e)
        {

        }

        private void UserValue1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserValue2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (radioAdd.Checked)
                {
                    (!string.IsNullOrEmpty(UserValue1.Text) && !string.IsNullOrEmpty(UserValue2.Text)).ToString();
                    CalculatedValue1.Text = (Convert.ToInt32(UserValue1.Text) + Convert.ToInt32(UserValue2.Text)).ToString();
                }
            else if (radioSubtract.Checked)
            {
                (!string.IsNullOrEmpty(UserValue1.Text) && !string.IsNullOrEmpty(UserValue2.Text)).ToString();
                CalculatedValue1.Text = (Convert.ToInt32(UserValue1.Text) - Convert.ToInt32(UserValue2.Text)).ToString();
            }
            else if (radioMultiply.Checked)
            {
                (!string.IsNullOrEmpty(UserValue1.Text) && !string.IsNullOrEmpty(UserValue2.Text)).ToString();
                CalculatedValue1.Text = (Convert.ToInt32(UserValue1.Text) * Convert.ToInt32(UserValue2.Text)).ToString();
            }
            else if (radioDivide.Checked)
            {
                try
                {
                    (!string.IsNullOrEmpty(UserValue1.Text) && !string.IsNullOrEmpty(UserValue2.Text)).ToString();
                    CalculatedValue1.Text = (Convert.ToInt32(UserValue1.Text) / Convert.ToInt32(UserValue2.Text)).ToString();
                }
                catch (DivideByZeroException dbz)
                {
                    MessageBox.Show("Enter a new number, you cannot divide 0");
                }
                catch (System.FormatException fe)
                {
                    MessageBox.Show("You cannot calculate without having both fields filled.");
                }
                
            }
                
                
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculatedValue_Click(object sender, EventArgs e)
        {

        }

        private void CalculatedValue1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
