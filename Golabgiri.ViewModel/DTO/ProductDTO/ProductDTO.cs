using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.ViewModel.DTO.ProductDTO
{
    public class ProductDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public string Unit { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
    }
}
