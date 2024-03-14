using Microsoft.AspNetCore.Mvc;

namespace JobListing.Controllers
{
    public class ApplicationController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
