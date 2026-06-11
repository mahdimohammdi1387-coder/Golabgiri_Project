using Golabgiri.Domain.Entities;
using Golabgiri.ViewModel.DTO.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glabgiri.DAL.IRepositories
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Task<IEnumerable<ProductDTO>> GetProduct(string search=""); 
    }
}
