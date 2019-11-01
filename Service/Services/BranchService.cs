using DataAccess;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Microsoft.EntityFrameworkCore;
using Service.Interface;
using DataAccess.UnitOfWork;

namespace Service.Services
{
    public class BranchService : IBranchService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BranchService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Branch> GetAll()
        {
            return _unitOfWork.BranchRepository.GetAll();
        }
        public Branch Get(int id)
        {
            return _unitOfWork.BranchRepository.Get(id);
        }
        public void Add(Branch branch)
        {
            _unitOfWork.BranchRepository.Add(branch);
            _unitOfWork.SaveChanges();
        }
        public void Update(Branch branchData)
        {
            var branchObject = _unitOfWork.BranchRepository.Get(branchData.Id);
            if (branchObject != null) branchObject.Name = branchData.Name;
            _unitOfWork.SaveChanges();
        }
        public void Delete(int id)
        {
            var branchObject = _unitOfWork.BranchRepository.Get(id);
            if (branchObject == null) return;
            _unitOfWork.BranchRepository.Remove(branchObject);
            _unitOfWork.SaveChanges();
        }
    }
}
