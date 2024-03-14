using Microsoft.AspNetCore.Mvc;

namespace JobListing.Controllers
{
    public class JobController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
