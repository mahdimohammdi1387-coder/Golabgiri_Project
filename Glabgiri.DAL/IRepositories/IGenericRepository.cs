using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Glabgiri.DAL.IRepositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        IQueryable<TEntity> GetAllQueryable(Expression<Func<TEntity, bool>> where = null);
        Task<TEntity> GetByIdAsync(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteByid(int id);
    }
}
