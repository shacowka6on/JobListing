using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobListing.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
