using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.Domain.Entities
{
    public class Production
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime Date { get; set; }
        public decimal UnitPrice { get; set; }
        [Required]
        [MaxLength(5)]
        public string Vahed { get; set; }
        public decimal Value { get; set; }
        public int ProductUnitId { get; set; }
        public decimal TotalAmount { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        #region relations
        public Product Product { get; set; }
        public ProductUnit ProductUnit { get; set; }
        public virtual ICollection<ActivitiesItem> ActivitiesItem { get; set; }
        #endregion
    }
}
