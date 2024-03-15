using JobListing.Infrastructure.Data.Models;
using JobListing.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobListing.Infrastructure.Data
{
    public class JobListingDbContext : IdentityDbContext
    {
        public JobListingDbContext(DbContextOptions<JobListingDbContext> options) 
            : base(options)
        { 
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApplicationConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new CompanyConfiguration());
            builder.ApplyConfiguration(new JobConfiguration());
            builder.ApplyConfiguration(new EmployerConfiguration());

            base.OnModelCreating(builder);
        }
        public DbSet<Application> Applications { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<Job> Jobs { get; set; } = null!;

        public DbSet<Employer> Employers = null!;
    }
}
