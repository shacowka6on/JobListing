using JobListing.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column(TypeName = "decimal(8,2)")]
        public decimal Salary { get; set; }
        [Required]
        public RolesEnum CategoryName { get; set; }
    }
}