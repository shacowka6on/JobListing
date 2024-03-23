using JobListing.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobListing.Infrastructure.Data.SeedDb
{
    internal class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            var data = new SeedData();

            builder.HasData(new Company[] { data.FirstCompany, data.SecondCompany, data.ThirdCompany });
        }
    }
}