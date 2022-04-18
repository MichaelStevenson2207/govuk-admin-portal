using Microsoft.AspNetCore.Mvc;

namespace govuk_admin_portal.Controllers
{
    public class OnlineApplicationQueueController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Detail()
        {
            return View();
        }
    }
}