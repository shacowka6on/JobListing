using JobListing.Infrastructure.Data.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JobListing.Infrastructure.Data.Models
{
    public class Application
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Phonenumber { get; set; } = string.Empty;
        [Required]
        public string Resume { get; set; } = string.Empty;
        [DefaultValue(ApplicationStatus.Pending)]
        public ApplicationStatus Status { get; set; }
    }
}
