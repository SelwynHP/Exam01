using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.BUS;

namespace WinFormsApp1.GUI
{
    public partial class MoneyExchangeForm : Form
    {
        CurrencyConversion c1;
        public MoneyExchangeForm()
        {
            InitializeComponent();
            c1 = new CurrencyConversion();
        }
        public void CaptureForm()
        {
            foreach (RadioButton element in groupBoxFrom.Controls)
            {
                if (element.Checked)
                {
                    c1.FromCur = (CurrencyType)Enum.Parse(typeof(CurrencyType), element.Text);
                    break;
                }
            }
            foreach (RadioButton element in groupBoxTo.Controls)
            {
                if (element.Checked)
                {
                    c1.ToCur = (CurrencyType)Enum.Parse(typeof(CurrencyType), element.Text);
                    break;
                }
            }
            try
            {
                c1.Operand1 = Convert.ToDouble(textBoxFromAmount.Text);
            }
            catch(FormatException fe) { MessageBox.Show(fe.Message + "\nPlease Enter a number in the provided field!", "Incorrect Format"); }
        }
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            CaptureForm();
            c1.Convert();
            textBoxToAmount.Text = c1.Operand2.ToString();
        }
        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            string str = "";
            using(StreamReader sr = new StreamReader(c1.path))
            {
                str = sr.ReadToEnd();
            }
            MessageBox.Show(str);
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to quit this application?", "Exit?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
