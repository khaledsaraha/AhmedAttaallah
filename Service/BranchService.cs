using DataAccess;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Service
{
    public class BranchService
    {
        private readonly Context _context;
        public BranchService(Context context)
        {
            _context = context;
        }
        public List<Branch> GetAll()
        {
            return _context.Branches.ToList();
        }
        public Branch Get(int id)
        {
            return _context.Branches.SingleOrDefault(branch => branch.Id == id);
        }
        public void Add(Branch branch)
        {
            _context.Branches.Add(branch);
            _context.SaveChanges();
        }
        public void Update(Branch branchData)
        {
            var branchObject = _context.Branches.SingleOrDefault(branch => branch.Id == branchData.Id);
            if (branchObject != null) branchObject.Name = branchData.Name;
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var branchObject = _context.Branches.SingleOrDefault(branch => branch.Id == id);
            if (branchObject == null) return;
            _context.Branches.Remove(branchObject);
            _context.SaveChanges();
        }
    }
}
