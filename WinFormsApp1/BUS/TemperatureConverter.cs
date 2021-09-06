using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.BUS
{
    enum TempConvertType { CtoF, FtoC }
    class TemperatureConverter
    {
        public readonly string path = "./TempConversions.txt";
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }
        public TempConvertType Type { get; set; }

        public TemperatureConverter()
        {
            this.Operand1 = 0;
            this.Operand2 = 0;
            this.Type = TempConvertType.CtoF;
        }
        public int ConvertTemp()
        {
            switch (this.Type)
            {
                case TempConvertType.CtoF:
                    this.Operand2 = (this.Operand1 * 9 / 5) + 32;
                    break;
                case TempConvertType.FtoC:
                    this.Operand2 = (this.Operand1 - 32) * 5 / 9;
                    break;
            }
            SaveTemperature();
            return this.Operand2;
        }
        public void SaveTemperature()
        {
            string label1, label2;
            if(this.Type == TempConvertType.CtoF)
            {
                label1 = "C";
                label2 = "F";
            }
            else
            {
                label1 = "F";
                label2 = "C";
            }
            StringBuilder sb = new StringBuilder();
            //1/2
            sb.Append(this.Operand1);
            sb.Append(" ");
            sb.Append(label1);
            sb.Append(" = ");
            sb.Append(this.Operand2);
            sb.Append(" ");
            sb.Append(label2);
            sb.Append(",");
            //2/2
            sb.Append("\t");
            sb.Append(DateTime.Now);
            //Writing out to text file
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(sb);
            }
        }
    }
}
