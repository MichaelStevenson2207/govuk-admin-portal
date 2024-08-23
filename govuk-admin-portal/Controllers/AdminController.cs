using Microsoft.AspNetCore.Mvc;

namespace govuk_admin_portal.Controllers;

public class AdminController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}