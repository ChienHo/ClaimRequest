using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using ChienHV1.ClaimRequest.Core.Model;

namespace ChienHV1.ClaimRequest.Core.Infrastructure.BaseGeneric
{
    class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly ClaimRequestContext _context;
        protected readonly DbSet<TEntity> _dbSet;
        public GenericRepository(ClaimRequestContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public int Add(TEntity entity)
        {
            _dbSet.Add(entity);
            return _context.SaveChanges();
        }

        public bool Update(TEntity entity)
        {
            _dbSet.AddOrUpdate(entity);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            return _context.SaveChanges() > 0;
        }

        public TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
