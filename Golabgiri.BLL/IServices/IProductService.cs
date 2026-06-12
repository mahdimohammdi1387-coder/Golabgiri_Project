using Golabgiri.ViewModel.DTO.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.BLL.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProductAsync(string search="");
        Task<bool> InsertProductAsync(ProductDTO productDTO);
        Task<bool> UpdateProductAsync(ProductDTO productDTO);
    }
}
