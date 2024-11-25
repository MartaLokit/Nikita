using Microsoft.AspNetCore.Mvc;

namespace dentist.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //HomePage
        public IActionResult HomePage()
        {
            return View();
        }
        public IActionResult Aplic()
        {
            return View("~/Views/User/Addza.cshtml");
        }
    }
}
