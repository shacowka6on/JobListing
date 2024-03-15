using JobListing.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace JobListing.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        public IdentityUser EmployerUser { get; set; } = null!;
        public IdentityUser GuestUser { get; set; } = null!;
        public Employer Employer { get; set; } = null!;

        public Application Application { get; set; } = null!;

        public Company FirstCompany { get; set; } = null!;
        public Company SecondCompany { get; set; } = null!;
        public Company ThirdCompany { get; set; } = null!;

        public Job Job1 { get; set; } = null!;
        public Job Job2 { get; set; } = null!;
        public Job Job3 { get; set; } = null!;

        public SeedData()
        {
            SeedApplications();
            SeedCompanies();
            SeedJobs();
            SeedEmployer();
            SeedUsers();
        }
        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            EmployerUser = new IdentityUser()
            { 
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "employer@gmail.com",
                NormalizedUserName = "employer@gmail.com",
                Email = "employer@gmail.com",
                NormalizedEmail = "employer@gmail.com"
            };
            EmployerUser.PasswordHash = hasher.HashPassword(EmployerUser, "qwerty123");

            GuestUser = new IdentityUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };
            GuestUser.PasswordHash = hasher.HashPassword(GuestUser, "guest123");

        }
        private void SeedEmployer()
        {
            Employer = new Employer()
            {
                Id = 1,
                Phonenumber = "+3591231239",
                UserId = EmployerUser.Id,
                CompanyId = 1,
            };
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
