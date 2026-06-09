using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.Domain.Enums
{
    public enum TransactionType
    {
        [Display(Name = "ورودی")]
        Input = 1,
        [Display(Name = "خروجی")]
        Output = 2,
        [Display(Name = "اول دوره")]
        BeginningPeriod = 3,
    }
}
