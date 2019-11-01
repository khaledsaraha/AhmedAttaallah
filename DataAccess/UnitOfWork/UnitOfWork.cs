using DataAccess.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public UnitOfWork(DbContext context,IBranchRepository branchRepository , IEmployRepository employRepository)
        {
            _context = context;
            BranchRepository = branchRepository;
            EmployRepository = employRepository;
        }

        public IBranchRepository BranchRepository { get; private set; }
        public IEmployRepository EmployRepository { get; private set; } 
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
