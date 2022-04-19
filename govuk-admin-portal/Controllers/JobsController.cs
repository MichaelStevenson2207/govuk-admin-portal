using Microsoft.AspNetCore.Mvc;

namespace govuk_admin_portal.Controllers
{
    public class JobsController : Controller
    {
        [HttpGet]
        public IActionResult Jobs()
        {
            return View();
        }
    }
}
