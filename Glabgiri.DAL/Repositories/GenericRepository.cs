using Glabgiri.DAL.Context;
using Glabgiri.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Glabgiri.DAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private AraghijatDbContext _db;
        private DbSet<TEntity> _dbset;
        public GenericRepository(AraghijatDbContext db)
        {
            _db = db;
            _dbset = _db.Set<TEntity>();
        }
        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbset.Attach(entity);
            }
            _dbset.Remove(entity);
        }

        public virtual void DeleteByid(int id)
        {
            var entity = _dbset.Find(id);
            Delete(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public IQueryable<TEntity> GetAllQueryable(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbset;
            if (where != null)
                query = query.Where(where);

            return query;
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbset.FindAsync(id);
        }

        public virtual void Insert(TEntity entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbset.Attach(entity);
            }
            _db.Entry(entity).State = EntityState.Modified;
        }
    }
}
