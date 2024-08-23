using System.Diagnostics;
using govuk_admin_portal.Models;
using Microsoft.AspNetCore.Mvc;

namespace govuk_admin_portal.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Cookies()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Accessibility()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}