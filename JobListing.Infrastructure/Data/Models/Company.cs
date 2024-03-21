using JobListing.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using static JobListing.Infrastructure.Constants.DataConstants;

namespace JobListing.Infrastructure.Data.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(CompanyNameMaxLength)]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        [MaxLength(CompanyDescriptionMaxLength)]
        public string CompanyDescription { get; set; } = string.Empty;
        [Required]
        [MaxLength(CompanyCardDescriptionMaxLength)]
        public string CompanyCardDescription { get; set; } = string.Empty;
        [Required]
        [MaxLength(LocationMaxLength)]
        public string Location {  get; set; } = string.Empty;
        [Required]
        [MaxLength(CompanyWebsiteMaxLength)]
        public string Website { get; set; } = string.Empty;
        [Required]
        public CompanySizeEnum Size { get; set; }
        public ICollection<Job> JobOffers { get; set; }
            = new List<Job>();
    }
}
