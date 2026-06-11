using Glabgiri.DAL.Context;
using Glabgiri.DAL.IRepositories;
using Golabgiri.Domain.Entities;
using Golabgiri.ViewModel.DTO.ProductDTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glabgiri.DAL.Repositories
{
    public class ProductRepository: GenericRepository<Product>,IProductRepository
    {
        private AraghijatDbContext _db;
        public ProductRepository(AraghijatDbContext context) :base(context)
        {
            _db = context;
        }
        
        public async Task<IEnumerable<ProductDTO>> GetProduct(string search="")
        {
            return await _db.Products.Include(x => x.ProductUnit).Where(x => search == "" ||
            x.ProductName.Contains(search)).Select(c => new ProductDTO
            {
                ID = c.ProductId,
                Name = c.ProductName,
                Value = c.Value,
                Unit = c.ProductUnit.UnitName,
                price = c.UnitPrice,
                description = c.Description
            }).ToListAsync();
        }
    }
}
