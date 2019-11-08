using System.Collections.Generic;
using AutoMapper;
using Entities;
using Service.Interface;
using DataAccess.UnitOfWork;
using Service.Dto;
using Service.Services.Base;

namespace Service.Services
{
    public class BranchService : BaseService,IBranchService
    {
        public BranchService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public IEnumerable<BranchDto> GetAll()
        {
            var entity = UnitOfWork.BranchRepository.GetAll();
            return Mapper.Map<IEnumerable<BranchDto>>(entity);
        }
        public BranchDto Get(int id)
        {
            var entity = UnitOfWork.BranchRepository.Get(id);
            return Mapper.Map<BranchDto>(entity);
        }
        public void Add(BranchDto branch)
        {
            UnitOfWork.BranchRepository.Add(Mapper.Map<Branch>(branch));
            UnitOfWork.SaveChanges();
        }
        public void Update(BranchDto branchData)
        {
            var branchObject = UnitOfWork.BranchRepository.Get(branchData.Id);
            if (branchObject != null) branchObject.Name = branchData.Name;
            UnitOfWork.SaveChanges();
        }
        public void Delete(int id)
        {
            var branchObject = UnitOfWork.BranchRepository.Get(id);
            if (branchObject == null) return;
            UnitOfWork.BranchRepository.Remove(branchObject);
            UnitOfWork.SaveChanges();
        }


    }
}
