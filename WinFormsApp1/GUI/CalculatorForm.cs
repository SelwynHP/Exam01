using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.BUS;

namespace WinFormsApp1.GUI
{
    public partial class CalculatorForm : Form
    {
        Calculator c1;
        public CalculatorForm()
        {
            InitializeComponent();
            c1 = new Calculator();
        }
        private void AppendEquation(string str)
        {
            textBoxEquation.Text+=str;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            c1.Add();
            textBoxEquation.Clear();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            c1.Subtract();
            textBoxEquation.Clear();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            c1.Multiply();
            textBoxEquation.Clear();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            c1.Divide();
            textBoxEquation.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            textBoxEquation.Text = c1.Equal().ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to quit this application?", "Exit?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEquation.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppendEquation("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppendEquation("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppendEquation("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppendEquation("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AppendEquation("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppendEquation("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AppendEquation("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppendEquation("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AppendEquation("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AppendEquation("0");
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            AppendEquation(".");
        }

        private void textBoxEquation_TextChanged(object sender, EventArgs e)
        {
            double cur;
            try
            {
                cur = Convert.ToDouble(textBoxEquation.Text);
                c1.CurrentValue = cur;
            }
            catch(Exception ex) { }
        }
    }
}
