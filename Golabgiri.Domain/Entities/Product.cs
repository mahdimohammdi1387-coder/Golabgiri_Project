using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.Domain.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(80)]
        public string ProductName { get; set; }
        public decimal Value { get; set; }
        public int ProductUnitId { get; set; }
        public decimal UnitPrice { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }
        #region relations
        public ProductUnit ProductUnit { get; set; }
        public virtual ICollection<ActivitiesItem> ActivitiesItem { get; set; }
        public virtual ICollection<Production> Production { get; set; }
        #endregion
    }
}
