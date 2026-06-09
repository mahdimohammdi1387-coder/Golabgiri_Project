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
        public async Task<bool> Delete(TEntity entity)
        {
            try
            {
                if (_db.Entry(entity).State == EntityState.Detached)
                {
                    _dbset.Attach(entity);
                }
                _dbset.Remove(entity);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public async Task<bool> DeleteByid(int id)
        {
            try
            {
                var entity = _dbset.Find(id);
                await Delete(entity);
                return true;
            }
            catch 
            {

                return false;
            }
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
            try
            {
                return await _dbset.FindAsync(id);
            }
            catch
            {

                return null;
            }
           
        }

        public async Task<bool> Insert(TEntity entity)
        {
            try
            {
                _dbset.Add(entity);
                return true;
            }
            catch 
            {

                return false;
            }
           
        }

        public async Task<bool> Update(TEntity entity)
        {
            try
            {
                if (_db.Entry(entity).State == EntityState.Detached)
                {
                    _dbset.Attach(entity);
                }
                _db.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch 
            {

                return false;
            }
               
        }
    }
}
