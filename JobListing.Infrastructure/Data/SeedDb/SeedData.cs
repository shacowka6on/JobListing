using JobListing.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace JobListing.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        public IdentityUser Employer { get; set; }
        public IdentityUser Guest { get; set; }
        public Application Application { get; set; }

        public Company FirstCompany { get; set; }
        public Company SecondCompany { get; set; }
        public Company ThirdCompany { get; set; }

        public Job Job1 { get; set; }
        public Job Job2 { get; set; }
        public Job Job3 { get; set; }

        public SeedData()
        {
            SeedApplications();
            SeedCompanies();
        }
        private void SeedJobs()
        {
            Job1 = new Job
            {
                Title = "Frontend Developer",
                Description = "We are looking for a frontend developer with experience in HTML, CSS, and JavaScript.",
                Roles = Enums.RolesEnum.Frontend,
                Location = "Gorna Malina",
                IsOpen = true,
                CreatedOn = DateTime.Now.AddDays(-5),
            };
            Job2 = new Job
            {

                Title = "Backend Developer",
                Description = "We are hiring a backend developer proficient in C# and .NET Core.",
                Roles = Enums.RolesEnum.Backend,
                Location = "Sofia",
                IsOpen = true,
                CreatedOn = DateTime.Now.AddDays(-2),
            };

        }
        private void SeedCompanies()
        {
            FirstCompany = new Company()
            {
                Id = 1,
                CompanyName = "First Company Tech",
                Location = "Centura Gorna Malina",
                Website = "http://firstcompanytech.com",
                Size = Enums.CompanySizeEnum.Small,
                JobOffers = new List<Job>
                {
                    Job1,
                }
            };
            SecondCompany = new Company()
            {
                Id = 2,
                CompanyName = "Second Company Solutions",
                Location = "Sofia",
                Website = "http://secondcompanysolutions.com",
                Size = Enums.CompanySizeEnum.Medium,
                JobOffers = new List<Job>
                {
                    Job2,
                }
            };
            ThirdCompany = new Company()
            {
                Id = 3,
                CompanyName = "Third Company Innovations",
                Location = "Plovdiv",
                Website = "http://thirdcompanyinnovations.com",
                Size = Enums.CompanySizeEnum.Large,
                JobOffers = new List<Job>
                {
                    Job3,
                }
            };
        }
        private void SeedApplications()
        {

        }
    }
}
