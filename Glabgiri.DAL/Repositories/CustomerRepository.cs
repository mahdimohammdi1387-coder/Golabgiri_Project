using Glabgiri.DAL.Context;
using Glabgiri.DAL.IRepositories;
using Golabgiri.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glabgiri.DAL.Repositories
{
    public class CustomerRepository:GenericRepository<Customer>,ICustomerRepository
    {
        private AraghijatDbContext db;
        public CustomerRepository(AraghijatDbContext context):base (context) 
        {
            db = context;
        }
    }
}
