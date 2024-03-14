using Microsoft.AspNetCore.Mvc;

namespace JobListing.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
