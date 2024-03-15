using JobListing.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobListing.Infrastructure.Data.SeedDb
{
    internal class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder
                .HasMany(c => c.JobOffers)
                .WithOne(j => j.Company)
                .HasForeignKey(j => j.CompanyId);
                
            var data = new SeedData();

            builder.HasData(new Company[] { data.FirstCompany, data.SecondCompany, data.ThirdCompany });
        }
    }
}