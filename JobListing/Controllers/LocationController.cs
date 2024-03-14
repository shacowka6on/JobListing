using Microsoft.AspNetCore.Mvc;

namespace JobListing.Controllers
{
    public class LocationController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
