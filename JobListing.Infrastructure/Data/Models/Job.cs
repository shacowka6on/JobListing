using JobListing.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using static JobListing.Infrastructure.Constants.DataConstants;

namespace JobListing.Infrastructure.Data.Models
{
    public class Job
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;
        [Required]
        public RolesEnum Roles { get; set; }
        [Required]
        [MaxLength(LocationMaxLength)]
        public string Location { get; set; } = string.Empty!;
        [Required]
        public int CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public Company Company { get; set; } = null!;
        [Required]
        public bool IsOpen { get; set; }
        [DisplayFormat(DataFormatString = JobDateTimeFormat)]
        public DateTime CreatedOn { get; set; }
        //[Required]
        //public int CategoryId { get; set; }
        //[ForeignKey(nameof(CategoryId))]
        //public Category Category { get; set; } = null!;
    }
}
