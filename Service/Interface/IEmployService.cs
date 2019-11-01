using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
  public  interface IEmployService
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
    }
}
