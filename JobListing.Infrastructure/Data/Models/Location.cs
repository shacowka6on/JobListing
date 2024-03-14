using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListing.Infrastructure.Models
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