using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CoreMVCEmptyStarter.Controllers
{
    public class LocalTimeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.CurrentTime = DateTime.Now;
            return View();
        }

        [HttpGet]
        public IActionResult GetCurrentTime()
        {
            string time = DateTime.Now.ToString();
            return Content(time);
        }
    }
}
