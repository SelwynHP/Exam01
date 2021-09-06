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
    public partial class IPValidatorForm : Form
    {
        public IPValidatorForm()
        {
            InitializeComponent();
            SetDate();
        }
        public void SetDate()
        {
            string str = "Today : ";
            str += new DateTime(2021,9,6).ToLongDateString();
            labelDate.Text = str;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxIPAddress.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to quit this application?", "Exit?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            string str = textBoxIPAddress.Text;
            if (IPValidator.Validate(str))
            {
                MessageBox.Show(str + "\nThis IP is correct", "Valid IP");
            }
            else
            {
                MessageBox.Show(str + "\nThe IP must have 4 bytes\ninteger number between 0 to 255\nseparated by a dot (255.255.255.255)");
            }
        }
    }
}
