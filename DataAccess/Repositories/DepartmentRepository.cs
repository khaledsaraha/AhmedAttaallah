using Common.Infrastructure;
using DataAccess.Interface;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        private readonly DbContext _context;

        public DepartmentRepository(DbContext context) : base(context)
        {
            _context = Context;
        }
    }
}
