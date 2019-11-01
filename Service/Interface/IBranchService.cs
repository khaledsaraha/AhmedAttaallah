using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IBranchService
    {
        IEnumerable<Branch> GetAll();
        Branch Get(int id);
        void Add(Branch branch);
        void Update(Branch branchData);
        void Delete(int id);
    }
}
