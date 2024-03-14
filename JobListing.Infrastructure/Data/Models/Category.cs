using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListing.Infrastructure.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public bool IsOpen { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}