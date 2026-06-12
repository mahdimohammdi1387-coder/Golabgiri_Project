using AutoMapper;
using Glabgiri.DAL.UnitOfWork;
using Golabgiri.BLL.IServices;
using Golabgiri.ViewModel.DTO.UnitDTo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.BLL.Services
{
    public class UnitService : IUnitService
    {
        private IUnitOfWork _db;
        private IMapper _mapper;
        public UnitService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _db=unitOfWork;
            _mapper=mapper;
        }
        public async Task<IEnumerable<UnitDTO>> GetUnit()
        {
            try
            {
                var unit= await _db.UnitRepository.GetAllAsync();
               return unit.Select(c=> _mapper.Map<UnitDTO>(c)).ToList();
            }
            catch 
            {

                return null;
            }
        }
    }
}
