using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Branch : BaseClass
    {
        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
    }
}
