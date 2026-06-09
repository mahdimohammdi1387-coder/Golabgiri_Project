using AutoMapper;
using Glabgiri.DAL.Context;
using Glabgiri.DAL.IRepositories;
using Glabgiri.DAL.UnitOfWork;
using Golabgiri.BLL.IServices;
using Golabgiri.BLL.Mapper;
using Golabgiri.Domain.Entities;
using Golabgiri.ViewModel.DTO.CustomerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.BLL.Services
{
    public class CustomerService:ICustomerService
    {
        private IUnitOfWork db;
        private readonly IMapper _mapper;
        public CustomerService(IMapper mapper,IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            db = unitOfWork;
        }
        public async Task<bool> InsertCustomerAsync(CustomerDTO info)
        {
            var customer = _mapper.Map<Customer>(info);
            try
            {
                await db.CustomerRepository.Insert(customer);
               
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public async Task<List<CustomerDTO>> GetAllCustomerAsync()
        {
                var customers = await db.CustomerRepository.GetAllAsync();
            return customers.Select(c => _mapper.Map<CustomerDTO>(c)).ToList();

        }

        public async Task<CustomerDTO> GetCustomerByIdAsync(int id)
        {
            return _mapper.Map<CustomerDTO> (await db.CustomerRepository.GetByIdAsync(id));
        }

        public async Task<bool> UpdateCustomerAsync(CustomerDTO info)
        {
            var customer=_mapper.Map<Customer>(info);
            try
            {
               await db.CustomerRepository.Update(customer);
              
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public async Task SaveAsync()
        {
            await db.SaveAsync();
        }
    }
}
