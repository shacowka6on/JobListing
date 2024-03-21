using JobListing.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using JobListing.Infrastructure.Data.SeedDb;

namespace JobListing.Infrastructure.Data.SeedDb
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder
                .HasOne(j => j.Category)
                .WithMany()
                .HasForeignKey(j => j.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            var data = new SeedData();
            builder.HasData(new Job[] { data.Job1, data.Job2, data.Job3 });
        }
    }
}