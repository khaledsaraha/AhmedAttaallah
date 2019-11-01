using DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IBranchRepository BranchRepository { get; }
        int SaveChanges();
    }
}
