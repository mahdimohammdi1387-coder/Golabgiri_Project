using AutoMapper;
using Glabgiri.DAL.UnitOfWork;
using Golabgiri.BLL.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.BLL.Services
{
    public class OriginalService : IOriginalService
    {
        private IUnitOfWork db;
        public OriginalService()
        {
            db = new UnitOfWork();
        }
        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
           db?.Save();
        }
    }
}
