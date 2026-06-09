using Glabgiri.DAL.Context;
using Glabgiri.DAL.IRepositories;
using Golabgiri.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glabgiri.DAL.Repositories
{
    public class LoginRepository:GenericRepository<Login>, ILoginRepository
    {
        private AraghijatDbContext db;
        public LoginRepository(AraghijatDbContext context) : base(context)
        {
            db = context;
        }

        public string GetUser(string username)
        {
            var user = db.Login.FirstOrDefault(c => c.UserName == username);
            return user != null ? user.Password : "";
        }
    }
}
