using JobListing.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListing.Infrastructure.Models
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
    }
}
