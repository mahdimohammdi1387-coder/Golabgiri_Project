using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.Domain.Entities
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public int TransactionId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        #region relations
        public Transaction transaction { get; set; }
        #endregion
    }
}
