using JobListing.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace JobListing.Infrastructure.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Location { get; set; } = string.Empty;
        [Required]
        public SeniorityEnum Seniority { get; set; }
        [Required] 
        public int PaidVacationDays { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public RolesEnum CategoryName { get; set; }
    }
}