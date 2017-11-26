using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManager.Models
{
    public class TaskOrder
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate{ get; set; }

        [Display(Name = "Duration (in months)")]
        public int Duration { get; set; }

        [Display(Name = "End Date")]
        public DateTime EndDate { get { return StartDate.AddMonths(Duration); } }

        [Display(Name = "Funding Value")]
        public double FundingValue { get; set; }

        public virtual Employee Manager { get; set; }
        public virtual List<Employee> Employees { get; set; }
        public virtual List<Month> Months { get; set; }

        public TaskOrder()
        {
            StartDate = DateTime.Today;
            Duration = 12;
            Manager = new Employee();
            Employees = new List<Employee>();
            Months = new List<Month>();
        }
    }
}