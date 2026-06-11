using Glabgiri.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glabgiri.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository CustomerRepository { get; }
        ILoginRepository LoginRepository { get; }
        IProductRepository ProductRepository { get; }
        Task SaveAsync();
        void Save();
        void Dispose();
    }
}
