using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class DummyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
