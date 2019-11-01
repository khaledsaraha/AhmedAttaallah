using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        //ICourseRepository Courses { get; }
        int SaveChanges();
    }
}
