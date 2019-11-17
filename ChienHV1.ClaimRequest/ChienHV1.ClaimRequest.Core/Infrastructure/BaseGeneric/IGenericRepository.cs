using System;
using System.Collections.Generic;

namespace ChienHV1.ClaimRequest.Core.Infrastructure.BaseGeneric
{
    public interface IGenericRepository<TEntity> : IDisposable
    {
        IEnumerable<TEntity> GetAll();
        int Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        TEntity GetById(object id);
    }
}