using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.ViewModel.DTO.CustomerDTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public decimal debit { get; set; }
        public decimal credit { get; set; }
        public int CustomerType { get; set; }
    }
}
