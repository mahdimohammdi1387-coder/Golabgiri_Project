using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.Utility.NumberOnly
{
    public static class NumberOnly
    {
       
        public static bool Only(Char caracter)
        {
            if (char.IsDigit(caracter) || caracter == '\b')
            {
                return false;
            }
            return true;
        }
    }
}
