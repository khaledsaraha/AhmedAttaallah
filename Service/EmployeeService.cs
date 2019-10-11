using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class EmployeeService
    {
        private readonly Context _context;
        public EmployeeService(Context context)
        {
            _context = context;
        }
        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }
        public Employee Get(int id)
        {
            return _context.Employees.SingleOrDefault(emp => emp.Id == id);
        }
        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
        public void Update(Employee employee)
        {
            var employeeObject = _context.Employees.SingleOrDefault(emp => emp.Id == employee.Id);
            employeeObject.Name = employee.Name;
            employeeObject.Salary = employee.Salary;
            employeeObject.IsWorking = employee.IsWorking;
            employeeObject.HiringDate = employee.HiringDate;
            employeeObject.DepartmentId = employee.DepartmentId;
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var employeeObject = _context.Employees.SingleOrDefault(emp => emp.Id == id);
            _context.Employees.Remove(employeeObject);
            _context.SaveChanges();
        }
    }
}
