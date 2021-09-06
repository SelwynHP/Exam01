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

namespace WinFormsApp1
{
    public partial class LottoForm : Form
    {
        readonly string path = "./LottoNbrs.txt";
        LottoType lottoType;
        public LottoForm(LottoType lotto)
        {
            InitializeComponent();
            lottoType = lotto;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //==============================================================
            //Generating Numbers
            int[] numbers = Lotto.GetNumbers(lottoType);
            //Creating a string representing the series of numbers in the textbox
            StringBuilder sbt = new StringBuilder();
            foreach(int num in numbers)
            {
                sbt.AppendLine(num.ToString());
            }
            //Loading string of numbers to textbox
            textBoxWinningNumbers.Text = sbt.ToString();

            //==============================================================
            //Logging each generated series of numbers
            StringBuilder sb1 = new StringBuilder();
            //1/4
            sb1.Append(lottoType.ToString()); sb1.Append(",\t");
            //2/4
            sb1.Append(DateTime.Today); sb1.Append(",\t");
            //3/4
            StringBuilder sbn = new StringBuilder();
            sbn.Append(numbers[0].ToString());
            for(int i = 1;i<numbers.Length - 1;i++)
            {
                sbn.Append(",");
                sbn.Append(numbers[i].ToString());
            }
            sb1.Append(sbn); sb1.Append("\t");
            //4/4
            sb1.Append("Extra " + numbers[numbers.Length - 1]); sb1.AppendLine();
            //Writing to file
            StreamWriter sw = new StreamWriter(path,true);
            sw.Write(sb1);
            sw.Close();
        }
        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            string str = "";
            using(StreamReader sr = new StreamReader(this.path))
            {
                str = sr.ReadToEnd();
            }
            MessageBox.Show(str);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to quit this application?", "Exit?", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
