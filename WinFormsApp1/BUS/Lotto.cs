using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.BUS
{
    public enum LottoType { Lotto649, LottoMax};
    public static class Lotto
    {
        private static int GetNumber()
        {
            return new Random().Next(1, 49);
        }
        public static int[] GetNumbers(LottoType type)
        {
            int maxNum = 0;
            if (type == LottoType.Lotto649)
            {
                maxNum = 6;
            }
            else if(type == LottoType.LottoMax)
            {
                maxNum = 7;
            }
            int maxExtra = 1;
            int maxLength = maxNum + maxExtra;
            int[] arNum = new int[maxLength];
            //Generating a series of random numbers
            for (int i = 0; i < maxLength; i++)
            {
                arNum[i] = Lotto.GetNumber();
            }

            return arNum;
        }
    }
}
