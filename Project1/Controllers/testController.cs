using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
	public class testController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
