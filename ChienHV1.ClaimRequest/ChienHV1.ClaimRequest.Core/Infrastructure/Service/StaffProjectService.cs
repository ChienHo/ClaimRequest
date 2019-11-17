using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChienHV1.ClaimRequest.Core.Infrastructure.BaseGeneric;
using ChienHV1.ClaimRequest.Core.Infrastructure.BaseService;
using ChienHV1.ClaimRequest.Core.Model;

namespace ChienHV1.ClaimRequest.Core.Infrastructure.Service
{
    public class StaffProjectService: BaseService<StaffProject>, IStaffProjectService
    {
        public StaffProjectService(IGenericRepository<StaffProject> context) : base(context)
        {
        }
    }
}
