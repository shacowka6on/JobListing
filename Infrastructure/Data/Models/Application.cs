using JobListing.Infrastructure.Data.Enums;

namespace JobListing.Infrastructure.Data.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phonenumber { get; set; } = string.Empty;
        public string Resume { get; set; } = string.Empty;
        public ApplicationStatus Status { get; set; }
    }
}
