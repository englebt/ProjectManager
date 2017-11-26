using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        
        [Display(Name = "Project Name")]
        public string Name { get; set; }

        [Display(Name = "Project Number")]
        public string Number { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        
        [Display(Name = "Duration (in months)")]
        public int Duration{ get; set; }
        
        public DateTime EndDate { get { return StartDate.AddMonths(Duration); } }

        public Statuses Status { get; set; }

        [Display(Name = "Contract Value")]
        public double ContractValue { get; set; } 
        
        [Display(Name = "Funding Value")]
        public double FundingValue { get; set; }

        [Display(Name = "PM")]
        public virtual Employee Manager { get; set; }
        public virtual List<TaskOrder> Tasks { get; set; }
        public virtual List<Employee> Employees { get; set; }

        public Project()
        {
            StartDate = DateTime.Today;
            Duration = 12;
            Manager = new Employee();
            Tasks = new List<TaskOrder>();
            Employees = new List<Employee>();
        }
    }
}
