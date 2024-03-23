using JobListing.Infrastructure.Data;
using JobListing.Models.Job;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobListing.Controllers
{
    public class JobController : Controller
    {
        private readonly JobListingDbContext data;
        public JobController(JobListingDbContext context)
        {
            data = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await data
                .Jobs
                .Select(j => new JobViewModel()
                {
                    Id = j.Id,
                    Title = j.Title,
                    Role = j.Roles,
                    IsOpen = j.IsOpen,
                    CompanyId = j.CompanyId,
                    Location = j.Location,

                }).ToListAsync();

            return View(model);
        }
        public async Task<IActionResult> JobDetails(int id)
        {
            var job = await data
                .Jobs
                .Include(j => j.Company)
                .FirstOrDefaultAsync(j => j.Id == id);

            if (job == null)
            {
                return NotFound();
            }

            var model = new JobDetailsViewModel()
            {
                Id = job.Id,
                Title = job.Title,
                Description = job.Description,
                CompanyId = job.CompanyId,
                Company = job.Company,
                Location = job.Location,
                IsOpen = job.IsOpen,
                Roles = job.Roles,
                CreatedOn = job.CreatedOn,
            };
            return View(model);
        }
    }
}
