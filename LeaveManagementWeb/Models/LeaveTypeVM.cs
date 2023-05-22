using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWeb.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Category")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Total Available Days")]
        [Required]
        [Range(1, 25, ErrorMessage ="Please enter a value within range: 1 - 25")]
        public int DefaultDays { get; set; }
    }
}
