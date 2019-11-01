using DataAccess;
using DataAccess.UnitOfWork;
using Entities;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Services
{
    public class EmployeeService : IEmployService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeService( IUnitOfWork unitOfWork)
        { 
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Employee> GetAll()
        {
            return _unitOfWork.EmployRepository.GetAll();
        }
        public Employee Get(int id)
        {
            return _unitOfWork.EmployRepository.Get(id);
        }
        public void Add(Employee employee)
        {
            _unitOfWork.EmployRepository.Add(employee);
            _unitOfWork.SaveChanges();
        }
        public void Update(Employee employee)
        {
            var employeeObject = _unitOfWork.EmployRepository.Get(employee.Id);
            employeeObject.Name = employee.Name;
            employeeObject.Salary = employee.Salary;
            employeeObject.IsWorking = employee.IsWorking;
            employeeObject.HiringDate = employee.HiringDate;
            employeeObject.DepartmentId = employee.DepartmentId;
            _unitOfWork.SaveChanges();
        }
        public void Delete(int id)
        {
            var employeeObject = _unitOfWork.EmployRepository.Get(id);
            _unitOfWork.EmployRepository.Remove(employeeObject);
            _unitOfWork.SaveChanges();
        }


    }
}
