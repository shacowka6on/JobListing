using System.ComponentModel.DataAnnotations;

namespace JobListing.Infrastructure.Data.Models
{
    public class Location
    {
        public int Id { get; set; }
        [Required]
        public string Street { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
    }
}