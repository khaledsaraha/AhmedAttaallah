using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class DepartmentService
    {
        private readonly Context _context;
        public DepartmentService(Context context)
        {
            _context = context;
        }
        public List<Department> GetAll()
        {
            return _context.Departments.ToList();
        }
        public Department Get(int id)
        {
            return _context.Departments.SingleOrDefault(dept => dept.Id == id);
        }
        public void Add(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }
        public void Update(Department department)
        {
            var deparmentObject = _context.Departments.SingleOrDefault(dept => dept.Id == department.Id);
            deparmentObject.Name = department.Name;
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var deparmentObject = _context.Departments.SingleOrDefault(dept => dept.Id == id);
            _context.Departments.Remove(deparmentObject);
            _context.SaveChanges();
        }
    }
}
