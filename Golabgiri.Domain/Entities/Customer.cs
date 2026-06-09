using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.Domain.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        [MaxLength(25)]
        public string Family { get; set; }
        [Required]
        [MaxLength(11)]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(250)]
        public string Address { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public CultureTypes Customertype { get; set; }
        #region relations
        public virtual ICollection<Transaction> Transaction { get; set; }
        #endregion
    }
}
