using Microsoft.AspNetCore.Mvc;

namespace MyInformationSystem.Controllers
{
    public class StudentController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
