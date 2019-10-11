using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee : BaseClass
    {
       
        [StringLength(50)]
        public string Name { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? HiringDate { get; set; }
        public bool IsWorking { get; set; }
        public int? DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }
}
