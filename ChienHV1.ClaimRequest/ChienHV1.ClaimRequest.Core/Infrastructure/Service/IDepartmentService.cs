using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChienHV1.ClaimRequest.Core.Infrastructure.BaseService;
using ChienHV1.ClaimRequest.Core.Model;

namespace ChienHV1.ClaimRequest.Core.Infrastructure.Service
{
    public interface IDepartmentService: IBaseService<Department>
    {
        IEnumerable<Department> GetByName(string name);
    }
}
