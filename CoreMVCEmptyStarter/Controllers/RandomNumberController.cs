using Microsoft.AspNetCore.Mvc;

namespace CoreMVCEmptyStarter.Controllers
{
    public class RandomNumberController : Controller
    {
        public IActionResult Index()
        {
            Random random = new Random();
            ViewBag.RandomNumber = random.Next(1, 100);
            return View();
        }

        [HttpGet]
        public IActionResult RandomNumber()
        {
            Random random = new Random();
            string value = random.Next(1, 100).ToString();
            return Content(value);
        }
    }
}
