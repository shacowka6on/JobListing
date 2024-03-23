using JobListing.Infrastructure.Data.Enums;
using JobListing.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobListing.Models.Job
{
    public class JobDetailsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public RolesEnum Roles { get; set; }
        public string Location { get; set; } = string.Empty!;
        public int CompanyId { get; set; }
        public Company Company { get; set; } = null!;
        public bool IsOpen { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
