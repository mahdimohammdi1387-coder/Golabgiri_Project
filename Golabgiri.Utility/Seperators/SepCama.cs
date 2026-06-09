using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.Utility.Seperators
{
    public static class SepCama
    {
        public static string Cama(string txt)
        {
            int l = txt.Length;
            while (l > 3)
            {
                l -= 3;
                txt = txt.Insert(l, ",");
            }
            return txt;
        }
        public static string NotCama(string txt)
        {
            return txt.Replace(",", "");
        }
    }
}
