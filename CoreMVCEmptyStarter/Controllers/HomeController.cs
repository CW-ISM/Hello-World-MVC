using Microsoft.AspNetCore.Mvc;

namespace CoreMVCEmptyStarter.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
