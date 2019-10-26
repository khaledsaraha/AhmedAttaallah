using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;

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
            var departmentObject = _context.Departments.SingleOrDefault(dept => dept.Id == department.Id);
            if(departmentObject == null) return;
             departmentObject.Name = department.Name;
             departmentObject.BranchId = department.BranchId;
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var departmentObject = _context.Departments.SingleOrDefault(dept => dept.Id == id);
            if (departmentObject == null) return;
            _context.Departments.Remove(departmentObject);
            _context.SaveChanges();
        }
    }
}
