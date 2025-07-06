using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
