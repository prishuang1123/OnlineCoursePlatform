using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
	public class Products : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
