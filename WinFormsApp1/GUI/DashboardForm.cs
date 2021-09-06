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
using WinFormsApp1.GUI;

namespace WinFormsApp1
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void pictureBoxLottoMax_Click(object sender, EventArgs e)
        {
            Form formLottoMax = new LottoForm(LottoType.LottoMax);
            formLottoMax.Text = "Lotto Max";
            formLottoMax.Show();
        }
        private void pictureBoxLotto649_Click(object sender, EventArgs e)
        {
            Form formLotto649 = new LottoForm(LottoType.Lotto649);
            formLotto649.Text = "Lotto 649";
            formLotto649.Show();
        }
        private void pictureBoxCalculator_Click(object sender, EventArgs e)
        {
            Form formCalculator = new CalculatorForm();
            formCalculator.Show();
        }
        private void pictureBoxMoneyExchange_Click(object sender, EventArgs e)
        {
            Form formMoneyExchange = new MoneyExchangeForm();
            formMoneyExchange.Show();
        }
        private void pictureBoxTemperatureConvert_Click(object sender, EventArgs e)
        {
            Form formTemperatureConversion = new TemperatureConversionForm();
            formTemperatureConversion.Show();
        }
        private void pictureBoxIpv4Validator_Click(object sender, EventArgs e)
        {
            Form formIPValidator = new IPValidatorForm();
            formIPValidator.Show();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
