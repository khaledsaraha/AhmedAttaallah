using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Service.Dto;

namespace Service.Interface
{
    public interface IBranchService
    {
        IEnumerable<BranchDto> GetAll();
        BranchDto Get(int id);
        void Add(BranchDto branch);
        void Update(BranchDto branchData);
        void Delete(int id);
    }
}
