using Microsoft.AspNetCore.Mvc;
using MvcCoreWebAppDemo1.Models;

namespace MvcCoreWebAppDemo1.Controllers
{
    public class CartController : Controller
    {
        private static readonly CartRepo _cartRepo = new CartRepo();

        public IActionResult Index()
        {
            var cart = _cartRepo.GetCart();
            return View(cart);
        }

        [HttpPost]
        public IActionResult Add(int id, int quantity = 1)
        {
            _cartRepo.AddToCart(id, quantity);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            _cartRepo.RemoveFromCart(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Clear()
        {
            _cartRepo.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
