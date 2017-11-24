using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManager.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double FundingValue { get; set; }

        public virtual Employee Manager { get; set; }
        public virtual List<Employee> Employees { get; set; }

        public Task()
        {
            Manager = new Employee();
            Employees = new List<Employee>();
        }
    }
}