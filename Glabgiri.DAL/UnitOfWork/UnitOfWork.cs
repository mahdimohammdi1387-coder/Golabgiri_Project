using Glabgiri.DAL.Context;
using Glabgiri.DAL.IRepositories;
using Glabgiri.DAL.Repositories;
using Glabgiri.DAL.UnitOfWork;
using Golabgiri.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glabgiri.DAL.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AraghijatDbContext _db;
        private ILoginRepository _loginrepository;
        private ICustomerRepository _customerrepository;
        private IProductRepository _productRepository;
        public UnitOfWork()
        {
            _db = new AraghijatDbContext();
        }

        public ILoginRepository LoginRepository { get
            {
                if(_loginrepository == null)
                    _loginrepository=new LoginRepository(_db);
                return _loginrepository;
            } 
        }
       
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerrepository == null)
                    _customerrepository = new CustomerRepository(_db);
                return _customerrepository;
            }
        }
        public IProductRepository ProductRepository
        {
            get
            {
                if(_productRepository==null)
                    _productRepository=new ProductRepository(_db);
                return _productRepository;
            }
        }
        public async Task SaveAsync() => await _db.SaveChangesAsync();

        public void Dispose()
        {
             _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
