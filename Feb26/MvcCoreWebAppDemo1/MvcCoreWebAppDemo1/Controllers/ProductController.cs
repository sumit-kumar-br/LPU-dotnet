using MvcCoreWebAppDemo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace MvcCoreWebAppDemo1.Controllers
{
    public class ProductController : Controller
    {
        ProductRepo prodRepo = null;
        public ProductController()
        {
            prodRepo = new ProductRepo();
        }

        [Route("")]
        [Route("Cosmetics")]
        [Route("Product/BeautyProduct")]
        public IActionResult Index1()
        {
            return View(prodRepo.GetAllCosmeticProducts());
        }
        public IActionResult Index2()
        {
            return View(prodRepo.GetAllCosmeticProducts());
        }
        public IActionResult Index3()
        {
            return View(prodRepo.GetAllCosmeticProducts());
        }

    }
}
