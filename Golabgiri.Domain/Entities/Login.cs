using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.Domain.Entities
{
    public class Login
    {
        [Key]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
