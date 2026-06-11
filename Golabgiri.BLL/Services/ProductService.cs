using AutoMapper;
using Glabgiri.DAL.UnitOfWork;
using Golabgiri.BLL.IServices;
using Golabgiri.ViewModel.DTO.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;
        public ProductService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _db = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProductDTO>> GetProductAsync(string search="")
        {
            try
            {
                return await _db.ProductRepository.GetProduct(search);
            }
            catch 
            {

                return null;
            }
        }
    }
}
