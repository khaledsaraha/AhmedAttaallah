using Common.Infrastructure;
using DataAccess.Interface;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class BranchRepository : Repository<Branch>, IBranchRepository
    {
        private readonly DbContext _context;
        public BranchRepository(DbContext context) : base(context)
        {
            _context = context;
        }

    }
}
