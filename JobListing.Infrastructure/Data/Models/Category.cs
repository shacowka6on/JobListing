using JobListing.Infrastructure.Data.Enums;

namespace JobListing.Infrastructure.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public RolesEnum CategoryName { get; set; }
    }
}