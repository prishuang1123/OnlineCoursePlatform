using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
