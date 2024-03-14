using Microsoft.AspNetCore.Mvc;

namespace JobListing.Controllers
{
    public class CompanyController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
