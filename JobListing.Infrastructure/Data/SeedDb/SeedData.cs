using JobListing.Infrastructure.Data.Enums;
using JobListing.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace JobListing.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        public IdentityUser EmployerUser { get; set; } = null!;
        public IdentityUser GuestUser { get; set; } = null!;

        public Application Application { get; set; } = null!;

        public Company FirstCompany { get; set; } = null!;
        public Company SecondCompany { get; set; } = null!;
        public Company ThirdCompany { get; set; } = null!;

        public Job Job1 { get; set; } = null!;
        public Job Job2 { get; set; } = null!;
        public Job Job3 { get; set; } = null!;

        public SeedData()
        {
            SeedUsers();
            SeedCompanies();
            SeedJobs();
            CompanyJobConnection();
            SeedApplications();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

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
        private void CompanyJobConnection()
        {
            Job1.CompanyId = FirstCompany.Id;
            Job2.CompanyId = FirstCompany.Id;
            Job3.CompanyId = FirstCompany.Id;
        }
        private void SeedJobs()
        {
            Job1 = new Job
            {
                Id = 1,
                Title = "Frontend Developer",
                Description = "We are looking for a frontend developer with experience in HTML, CSS, and JavaScript.",
                Roles = Enums.RolesEnum.Frontend,
                Location = "Gorna Malina",
                CompanyId = FirstCompany.Id,
                IsOpen = true,
                CreatedOn = DateTime.Now.AddDays(-5),
            };
            Job2 = new Job
            {
                Id = 2,
                Title = "Backend Developer",
                Description = "We are hiring a backend developer proficient in C# and .NET Core.",
                Roles = Enums.RolesEnum.Backend,
                Location = "Sofia",
                CompanyId = FirstCompany.Id,
                IsOpen = true,
                CreatedOn = DateTime.Now.AddDays(-2),
            };
            Job3 = new Job
            {
                Id = 3,
                Title = "Full-stack Developer",
                Description = "We are seeking a full-stack developer with experience in both frontend and backend technologies.",
                Roles = RolesEnum.Fullstack,
                Location = "Plovdiv",
                CompanyId = FirstCompany.Id,
                IsOpen = true,
                CreatedOn = DateTime.Now.AddHours(-6),
            };

        }
        private void SeedCompanies()
        {
            FirstCompany = new Company()
            {
                Id = 1,
                CompanyName = "First Company Tech",
                CompanyCardDescription = "We are the FirstCompanyTech. We specialize in techy stuff",
                Location = "Centura Gorna Malina",
                Website = "http://firstcompanytech.com",
                Size = Enums.CompanySizeEnum.Small,
            };
            SecondCompany = new Company()
            {
                Id = 2,
                CompanyName = "Second Company Solutions",
                CompanyCardDescription = "We are the SecondCompanySolutions. We specialize in techy stuff solutions",
                Location = "Sofia",
                Website = "http://secondcompanysolutions.com",
                Size = Enums.CompanySizeEnum.Medium,
            };
            ThirdCompany = new Company()
            {
                Id = 3,
                CompanyName = "Third Company Innovations",
                CompanyCardDescription = "We are the ThirdCompanyInnovations. We specialize in inovating techy stuff",
                Location = "Plovdiv",
                Website = "http://thirdcompanyinnovations.com",
                Size = Enums.CompanySizeEnum.Large,
            };
        }
        private void SeedApplications()
        {
            Application = new Application()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Resume = "Lorem ipsum...",
                Status = ApplicationStatus.Pending,
            };
        }
    }
}
