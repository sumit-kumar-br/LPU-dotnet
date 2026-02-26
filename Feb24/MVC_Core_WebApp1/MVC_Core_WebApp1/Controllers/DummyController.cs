using Microsoft.AspNetCore.Mvc;

namespace MVC_Core_WebApp1.Controllers
{
    public class DummyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult CallError()
        {
            throw new Exception("My Custom Exception");
        }
    }
}
