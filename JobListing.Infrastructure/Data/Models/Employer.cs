using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static JobListing.Infrastructure.Constants.DataConstants;

namespace JobListing.Infrastructure.Data.Models
{
    public class Employer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(PhonenumberMaxLength)]
        public string Phonenumber { get; set; } = string.Empty;
        [Required]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
        [Required]
        public int CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public Company Company { get; set; } = null!;
    }
}
