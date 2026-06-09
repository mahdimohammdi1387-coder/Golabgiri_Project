using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.Domain.Enums
{
    public enum ActivityItem
    {
        [Display(Name = "تراکنش")]
        transaction = 1,
        [Display(Name = "تولید")]
        Production = 2,
    }
}
