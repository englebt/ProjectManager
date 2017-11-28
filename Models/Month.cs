using System.ComponentModel.DataAnnotations;

namespace ProjectManager.Models
{
    public class Month
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        [Display(Name = "Available Hours")]
        public double AvailableHours { get; set; }

        [Display(Name = "Allocated Hours")]
        public double AllocatedHours { get;set;}

        [Display(Name = "Available Funding")]
        public double AvailableFunding { get; set; }

        [Display(Name = "Allocated Funding")]
        public double AllocatedFunding { get; set; }
    }
}