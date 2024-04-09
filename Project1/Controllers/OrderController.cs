using Microsoft.AspNetCore.Mvc;
using Project1.Data;
using Project1.Models;


namespace Project1.Controllers
{
    public class OrderController : Controller
    {
        private readonly ProjectDbContext _db;
        public OrderController(ProjectDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Order> orders = _db.Order.ToList();
            return View(orders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Order obj)
        {
            HashSet<Order> objCategoryHashset = _db.Order.ToHashSet();
            if (objCategoryHashset.Any(old => old.OrderID == obj.OrderID))
            {
                ModelState.AddModelError("OrderID", "The order ID has already existed!");
            }

            if (ModelState.IsValid)
            {
                _db.Order.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "Order");
            }
            return View();
        }
    }
}
