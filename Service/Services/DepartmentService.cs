using DataAccess;
using DataAccess.UnitOfWork;
using Entities;
using Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Service.Services
{
    public class DepartmentService: IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DepartmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Department> GetAll()
        {
            return _unitOfWork.DepartmentRepository.GetAll();
        }
        public Department Get(int id)
        {
            return _unitOfWork.DepartmentRepository.Get(id);
        }
        public void Add(Department department)
        {
            _unitOfWork.DepartmentRepository.Add(department);
            _unitOfWork.SaveChanges();
        }
        public void Update(Department department)
        {
            var departmentObject = _unitOfWork.DepartmentRepository.Get(department.Id);
            if(departmentObject == null) return;
             departmentObject.Name = department.Name;
             departmentObject.BranchId = department.BranchId;
            _unitOfWork.SaveChanges();
        }
        public void Delete(int id)
        {
            var departmentObject = _unitOfWork.DepartmentRepository.Get(id);
            if (departmentObject == null) return;
            _unitOfWork.DepartmentRepository.Remove(departmentObject);
            _unitOfWork.SaveChanges();
        }
    }
}
