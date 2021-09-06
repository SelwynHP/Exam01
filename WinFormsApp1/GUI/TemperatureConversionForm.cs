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
    public partial class TemperatureConversionForm : Form
    {
        TemperatureConverter tc;
        public TemperatureConversionForm()
        {
            InitializeComponent();
            radioButtonCtoF.Checked = true;
            tc = new TemperatureConverter();
        }
        public void CaptureClass()
        {
            try
            {
                tc.Operand1 = Convert.ToInt32(textBoxTemp1.Text);
            }
            catch(FormatException fe) { MessageBox.Show(fe.Message + "\nPlease the proper format for this field", "Incorrect Format"); }

            if (radioButtonCtoF.Checked)
            {
                tc.Type = TempConvertType.CtoF;
            }
            else
            {
                tc.Type = TempConvertType.FtoC;
            }
        }
        public string ConverterMessage()
        {
            string str = "";
            if(tc.Type == TempConvertType.FtoC)
            {
                switch (tc.Operand2)
                {
                    case >= 100:
                        str = "Water Boils";
                        break;
                    case int n when n >= 40 && n < 100:
                        str = "Hot Bath";
                        break;
                    case int n when n >= 37 && n < 40:
                        str = "Body Temperature";
                        break;
                    case int n when n >= 30 && n < 37:
                        str = "Beach Weather";
                        break;
                    case int n when n >= 21 && n < 30:
                        str = "Room Temperature";
                        break;
                    case int n when n >= 10 && n < 21:
                        str = "Cool Day";
                        break;
                    case int n when n >= 0 && n < 10:
                        str = "Freezing point of water";
                        break;
                    case int n when n >= -18 && n < 0:
                        str = "Very Cold Day";
                        break;
                    case int n when n >= -40 && n < -18:
                        str = "Extremely Cold Day";
                        break;
                    default:
                        str = "Nothing to tell you...";
                        break;
                }
            }
            else
            {
                switch (tc.Operand2)
                {
                    case >= 212:
                        str = "Water Boils";
                        break;
                    case int n when n >= 104 && n < 212:
                        str = "Hot Bath";
                        break;
                    case int n when n >= 98.6 && n < 104:
                        str = "Body Temperature";
                        break;
                    case int n when n >= 86 && n < 98.6:
                        str = "Beach Weather";
                        break;
                    case int n when n >= 70 && n < 86:
                        str = "Room Temperature";
                        break;
                    case int n when n >= 50 && n < 70:
                        str = "Cool Day";
                        break;
                    case int n when n >= 32 && n < 50:
                        str = "Freezing point of water";
                        break;
                    case int n when n >= 0 && n < 32:
                        str = "Very Cold Day";
                        break;
                    case int n when n >= -40 && n < 0:
                        str = "Extremely Cold Day";
                        break;
                    default:
                        str = "Nothing to tell you...";
                        break;
                }
            }
            return str;
        }
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            CaptureClass();
            textBoxTemp2.Text = tc.ConvertTemp().ToString();
            textBoxMessage.Text = ConverterMessage();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to quit this application?", "Exit?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            string str = "";
            using(StreamReader sr = new StreamReader(tc.path))
            {
                str = sr.ReadToEnd();
            }
            MessageBox.Show(str, "Results");
        }

        private void radioButtonCtoF_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCtoF.Checked)
            {
                labelTemp1.Text = "C";
                labelTemp2.Text = "F";
            }
            else
            {
                labelTemp1.Text = "F";
                labelTemp2.Text = "C";
            }
        }
    }
}
