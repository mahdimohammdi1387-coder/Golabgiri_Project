using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.Utility.Seperators
{
    public static class PointSeprator
    {
        public static string RemoveTrailingZeros(decimal value)
        {
            string formatted = value.ToString("0.####", CultureInfo.InvariantCulture); 
            if (formatted.EndsWith('.'.ToString()))
            {
                formatted = formatted.Substring(0, formatted.Length - 1);
            }

            if (string.IsNullOrEmpty(formatted))
            {
                return "0";
            }


            return formatted;
        }
    }
}
