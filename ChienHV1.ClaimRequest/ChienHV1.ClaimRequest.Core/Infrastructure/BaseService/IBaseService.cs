using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChienHV1.ClaimRequest.Core.Infrastructure.BaseGeneric;

namespace ChienHV1.ClaimRequest.Core.Infrastructure.BaseService
{
    public interface IBaseService<TEntity> : IDisposable
    {
        IEnumerable<TEntity> GetAll();
        int Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        bool Delete(object id);
        TEntity GetById(object id);
    }
}
