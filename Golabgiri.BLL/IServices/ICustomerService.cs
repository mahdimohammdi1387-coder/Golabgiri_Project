using Golabgiri.ViewModel.DTO.CustomerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.BLL.IServices
{
    public interface ICustomerService
    {
        Task<bool> InsertCustomerAsync(CustomerDTO info);
        Task<bool> UpdateCustomerAsync(CustomerDTO info);
        Task<IEnumerable<CustomerDTO>> GetAllCustomerAsync();
        Task<CustomerDTO> GetCustomerByIdAsync(int id);
        Task SaveAsync();
        void Save();
    }
}
