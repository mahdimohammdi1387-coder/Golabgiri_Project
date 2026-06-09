using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.Utility.Seperators
{
    public static class NumberCardSeprator
    {
        public static string SeprateCard(string txt)
        {
            int l = txt.Length;
            while (l > 4)
            {
                l -= 4;
                txt = txt.Insert(l, "_");
            }
            return txt;
        }
        public static string NotSeprateCard(string txt)
        {
            return txt.Replace("_", "");
        }
    }
}
