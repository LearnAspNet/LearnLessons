using Microsoft.AspNetCore.Mvc;

namespace LessonTwo.Api.Controllers
{
    public class NewGuidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
