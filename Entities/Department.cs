using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Department : BaseClass
    {
        [StringLength(100)]
        public string Name { get; set; }
        public int? BranchId  { get; set; }
        [ForeignKey("BranchId")]
        public virtual Branch Branch { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
