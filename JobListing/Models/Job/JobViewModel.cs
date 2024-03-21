using JobListing.Infrastructure.Data.Enums;
using JobListing.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobListing.Models.Job
{
    public class JobViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public RolesEnum Role { get; set; }
        public string Location { get; set; } = string.Empty!;
        public int CompanyId { get; set; }
        public bool IsOpen { get; set; }
    }
}
