using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsApp1.BUS
{
    public static class IPValidator
    {
        public static bool Validate(string str)
        {
            string pattern = @"^[0-9]{1,3}(?>\.[0-9]{1,3}){3}$";
            Match match = Regex.Match(str, pattern);
            return match.Success;
        }
    }
}
