using System.ComponentModel.DataAnnotations;

namespace ProjectManager.Models
{
    public class Month
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        [Display(Name = "Available Hours")]
        public int AvailableHours { get; set; }

        [Display(Name = "Available Funding")]
        public double AvailableFunding { get; set; }

        [Display(Name = "Allocated Funding")]
        public double AllocatedFunding { get; set; }
    }
}