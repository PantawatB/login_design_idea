using Microsoft.AspNetCore.Mvc;
namespace pantawat.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
