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
    public class ActivitiesItem
    {
        [Key]
        public int Id { get; set; }
        public ActivityItem ActivityItem { get; set; }
        public int ActivityId { get; set; }
        public int ProductId { get; set; }
        public decimal Value { get; set; }
        public int ProductUnitId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount { get; set; }
        #region relations
        public Product Product { get; set; }
        public ProductUnit ProductUnit { get; set; }
        public Transaction Transaction { get; set; }
        public Production Production { get; set; }
        #endregion
    }
}
