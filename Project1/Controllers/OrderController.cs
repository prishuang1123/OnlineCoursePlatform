using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;
using System.Diagnostics.Metrics;


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
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order obj)
        {
            HashSet<Order> objOrderHashset = _db.Order.ToHashSet();
            if (objOrderHashset.Any(old => old.OrderID == obj.OrderID))
            {
                ModelState.AddModelError("OrderID", "The order ID has already existed!");
            }

            if (ModelState.IsValid)
            {
                _db.Order.Add(obj);
                _db.SaveChanges();
				TempData["success"] = "訂單創建功!!";
				return RedirectToAction("Index", "Order");
            }
            return View();
        }
        public async Task<IActionResult> ViewDetails(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Order? orderObj = await _db.Order.FirstOrDefaultAsync(obj => obj.OrderID == id);
			IEnumerable<OrderDetail>? orderDetailObjList = await _db.OrderDetail.Where(obj => obj.OrderID == id).ToListAsync();
            if (orderDetailObjList == null||orderObj==null)
            {
                return NotFound();
            }
			OrderDetailsViewModel? orderDetailsViewModel = new OrderDetailsViewModel
            {
                order = orderObj,
                orderDetails = orderDetailObjList
            };

            if (orderDetailsViewModel == null)
            {
                return NotFound();
            }
            return View(orderDetailsViewModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || id==0) {
                return NotFound();
            }
            Order? orderObj = await _db.Order.FirstOrDefaultAsync(obj => obj.OrderID == id);
            if (orderObj == null)
            {
                return NotFound();
            }
            return View(orderObj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Order obj)
        {
            
            if (ModelState.IsValid)
            {
              
                try
                {
					obj.ModifiedAt = DateTime.UtcNow;
					_db.Order.Update(obj);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(obj.OrderID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
				TempData["success"] = "訂單更新成功!!";
				return RedirectToAction("Index", "Order");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Order orderObj = _db.Order.FirstOrDefault(obj => obj.OrderID == id);
            if (orderObj == null)
            {
                return NotFound();
            }
            return View(orderObj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Order obj)
        { 
            _db.Order.Remove(obj);
            _db.SaveChanges();
			TempData["success"] = "訂單刪除成功!!";
			return RedirectToAction("Index", "Order");
        }

        private bool OrderExists(int id)
        {
            return _db.Order.Any(e => e.OrderID == id);
        }
    }
}
