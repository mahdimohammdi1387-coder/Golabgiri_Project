using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.Domain.Entities
{
    public class ProductUnit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string UnitName { get; set; }


        #region relations
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<Production> Production { get; set; }
        public virtual ICollection<ActivitiesItem> ActivitiesItem { get; set; }
        #endregion
    }
}
