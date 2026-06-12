using Glabgiri.DAL.Context;
using Glabgiri.DAL.IRepositories;
using Glabgiri.DAL.UnitOfWork;
using Golabgiri.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glabgiri.DAL.Repositories
{
    public class UnitRepository:GenericRepository<ProductUnit>,IUnitRepository
    {
         AraghijatDbContext db;
        public UnitRepository(AraghijatDbContext context):base(context) 
        {
            db = context;
        }
    }
}
