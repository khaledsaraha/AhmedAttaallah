using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Department : BaseClass
    {
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
