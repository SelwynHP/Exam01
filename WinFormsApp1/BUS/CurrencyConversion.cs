using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.BUS
{
    public enum CurrencyType { CAD, USD, EUR, GBP, KRW }
    public class CurrencyConversion
    {
        public readonly string path = "./MoneyConversions.txt";
        Dictionary<CurrencyType, double> Currencies = new Dictionary<CurrencyType, double>()
        {
            { CurrencyType.CAD, 1 },
            { CurrencyType.USD, 1.25 },
            { CurrencyType.EUR, 1.49 },
            { CurrencyType.GBP, 1.73 },
            { CurrencyType.KRW, 0.0011 }
        };
        public CurrencyType FromCur { get; set; }
        public CurrencyType ToCur { get; set; }
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }

        public CurrencyConversion()
        {
            FromCur = CurrencyType.CAD;
            ToCur = CurrencyType.CAD;
            Operand1 = 0.00;
            Operand2 = 0.00;
        }
        private double ConvertToCAD()
        {
            return Operand1 * Currencies[FromCur];
        }
        public void Convert()
        {
            double num1 = 0;
            num1 = ConvertToCAD();
            Operand2 = num1 / Currencies[ToCur];
            SaveConversion();
        }
        private void SaveConversion()
        {
            StringBuilder sb = new StringBuilder();
            //1/2
            sb.Append(Operand1);
            sb.Append(" ");
            sb.Append(FromCur.ToString());
            sb.Append(" = ");
            sb.Append(Operand2);
            sb.Append(" ");
            sb.Append(ToCur.ToString());
            sb.Append(",");
            //2/2
            sb.Append("\t");
            sb.Append(DateTime.Now);
            //Writing out to text file
            using(StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(sb);
            }
        }
    }
}
