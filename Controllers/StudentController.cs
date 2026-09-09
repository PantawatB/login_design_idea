using Microsoft.AspNetCore.Mvc;
namespace pantawat.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult ShowScore (int id)
        {
            return Content($"detail {id}");
        }
        
    }
}