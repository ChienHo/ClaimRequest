using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChienHV1.ClaimRequest.Core.Infrastructure.BaseGeneric;

namespace ChienHV1.ClaimRequest.Core.Infrastructure.BaseService
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        protected readonly IGenericRepository<TEntity> _context;

        public BaseService(IGenericRepository<TEntity> context)
        {
            _context = context;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.GetAll();
        }

        public int Add(TEntity entity)
        {
            return _context.Add(entity);
        }

        public bool Update(TEntity entity)
        {
            return _context.Update(entity);
        }

        public bool Delete(TEntity entity)
        {
            return _context.Delete(entity);
        }

        public bool Delete(object id)
        {
            if (id == null)
            {
                throw new Exception("Id is NULL! Please enter Id!");
            }

            var item = _context.GetById(id);
            if (item == null)
            {
                throw new Exception("Object not Exit!");
            }

            return Delete(item);
        }

        public TEntity GetById(object id)
        {
            return _context.GetById(id);
        }
    }
}
