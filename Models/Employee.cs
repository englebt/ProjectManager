using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManager.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<TaskOrder> Tasks { get; set; }
    }
}
