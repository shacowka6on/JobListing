using JobListing.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace JobListing.Infrastructure.Data.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        public string Location {  get; set; } = string.Empty;
        [Required]
        public string Website { get; set; } = string.Empty;
        public CompanySizeEnum Size { get; set; }
        public ICollection<Job> JobOffers { get; set; }
            = new List<Job>();
    }
}
