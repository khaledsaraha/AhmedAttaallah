using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAll();
        Department Get(int id);
        void Add(Department department);
        void Update(Department department);
        void Delete(int id);
    }
}
