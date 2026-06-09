using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.Domain.Enums
{
    public enum CustomerType
    {
        [Display(Name ="شخص")]
        person=1,
        [Display(Name ="شرکت")]
        company=2
    }
}
