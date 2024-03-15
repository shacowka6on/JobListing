using JobListing.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobListing.Infrastructure.Data.SeedDb
{
    internal class EmployerConfiguration : IEntityTypeConfiguration<Employer>
    {
        public void Configure(EntityTypeBuilder<Employer> builder)
        {
            builder
                .HasOne(e => e.Company)
                .WithMany(c => c.Employers)
                .HasForeignKey(e => e.CompanyId);

            var data = new SeedData();

            builder.HasData(new Employer[] { data.Employer });
        }
    }
}
