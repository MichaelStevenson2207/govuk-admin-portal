using Microsoft.AspNetCore.Mvc;

namespace govuk_admin_portal.Controllers
{
    public class SettingsController : Controller
    {
        [HttpGet]
        public IActionResult Settings()
        {
            return View();
        }
    }
}