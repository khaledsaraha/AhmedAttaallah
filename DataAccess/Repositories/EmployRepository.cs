using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using  Common.Infrastructure;
using DataAccess.Interface;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
   public class EmployRepository : Repository<Employee>, IEmployRepository
    {
        private readonly DbContext _context;
            public EmployRepository(DbContext context) : base (context)
        {
            _context = context;
        }
    }
}
