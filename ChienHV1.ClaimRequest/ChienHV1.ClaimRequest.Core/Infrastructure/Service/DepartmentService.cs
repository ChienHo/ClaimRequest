﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChienHV1.ClaimRequest.Core.Infrastructure.BaseGeneric;
using ChienHV1.ClaimRequest.Core.Infrastructure.BaseService;
using ChienHV1.ClaimRequest.Core.Model;

namespace ChienHV1.ClaimRequest.Core.Infrastructure.Service
{
    public  class DepartmentService: BaseService<Department>, IDepartmentService
    {
        public DepartmentService(IGenericRepository<Department> context) : base(context)
        {
        }

        public IEnumerable<Department> GetByName(string name)
        {
            return _context.GetAll().Where(d => d.DepartmentName.Contains(name)).ToList();
        }
    }
}
