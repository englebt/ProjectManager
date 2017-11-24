using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManager.Models
{
    public class Project
    {
        public enum Statuses
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Statuses Status { get; set; }

        public double ContractValue { get; set; } 
        public double FundingValue { get; set; }

        public virtual Employee Manager { get; set; }
        public virtual List<Task> Tasks { get; set; }
        public virtual List<Employee> Employees { get; set; }

        public Project()
        {
            Manager = new Employee();
            Tasks = new List<Task>();
            Employees = new List<Employee>();
        }
    }
}
