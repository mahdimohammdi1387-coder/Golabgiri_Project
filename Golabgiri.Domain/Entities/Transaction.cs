using Golabgiri.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.Domain.Entities
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int CustomerId { get; set; }
        public TransactionType TransactionType { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        [Required]
        [MaxLength(5)]
        public string Vahed { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        #region relations
        public Customer Customer { get; set; }
        public virtual ICollection<ActivitiesItem> ActivitiesItem { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        #endregion
    }
}
