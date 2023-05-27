using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace govuk_admin_portal.Controllers
{
    public class HelperController : Controller
    {
        public RedirectToActionResult TimeoutResult()
        {
            return RedirectToAction("TimedOut", "Helper");
        }

        [HttpGet]
        public async Task<IActionResult> TimedOut()
        {
            return View();
        }
    }
}
