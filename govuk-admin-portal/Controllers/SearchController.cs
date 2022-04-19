using Microsoft.AspNetCore.Mvc;

namespace govuk_admin_portal.Controllers
{
    public class SearchController : Controller
    {
        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }
    }
}