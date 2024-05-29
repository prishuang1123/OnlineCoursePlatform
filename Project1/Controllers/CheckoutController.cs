using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;
using Project1.ViewModels;

namespace Project1.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ProjectDbContext _db;


        public CheckoutController(ProjectDbContext db) 
        {
            _db = db;

        }
        public async Task<IActionResult> Index(int? id, string? discountCode) //memberId, discountObj
        {
            DbSet<Course> course = _db.Course;
            IEnumerable<ShoppingCart>memberShoppingCart = await _db.Cart.Where(u => u.MemberID == id).ToListAsync();
            Member memberObj = await _db.Member.Where(obj=>obj.MemberID==id).FirstOrDefaultAsync();
            Discount discountObj = await _db.Discount.Where(obj=>obj.DiscountName==discountCode).FirstOrDefaultAsync();
            IEnumerable<Location> locationList = await _db.Location.ToListAsync();
            var courseObjList = memberShoppingCart
                .GroupBy(c => c.CourseID)
                .Select(cs => new ShoppingCart // Assuming ShoppingCart has a constructor
                {
                    CourseID = cs.Key,
                    Quantity = cs.Sum(c => c.Quantity),
                    // Example of setting other properties, adjust as needed
                    // CartIdToScheduleDate = cs.Select(c => new { CartID = c.CartID, ScheduleDate = _db.ClassSchedule.Where(s => s.SchedulerID == c.SchedulerID).FirstOrDefault().Scheduler }).ToArray(),
                }).ToList(); // Convert to list
            //var courseObjList = memberShoppingCart
            //    .GroupBy(c => c.CourseID)
            //    .Select(cs => new
            //    {
            //        CourseID = cs.Key,
            //        Quantity = cs.Sum(c => c.Quantity),
            //        CartIdToScheduleDate = cs.Select(c => new { CartID = c.CartID, ScheduleDate = _db.ClassSchedule.Where(s => s.SchedulerID == c.SchedulerID).FirstOrDefault().Scheduler }).ToArray(),

            //    });
            //public Member Member { get; set; }
            //public Discount Discount { get; set; }
            //public Order Order { get; set; }
            //public OrderDetail OrderDetail { get; set; }
            //public Payment Payment { get; set; }
            //IEnumerable<Location> Location { get; set; }
            decimal initSubtotal = 0;
            foreach(var item in courseObjList)
            {
                initSubtotal += (item.Quantity) * (_db.Course.Where(c => c.CourseID == item.CourseID).FirstOrDefault().Price);
            }

            CheckoutVM checkoutVM = new CheckoutVM()
            {
                Member = memberObj,
                Discount = discountObj,
                Location = locationList,
                cartItemList= memberShoppingCart,
                courseObjList= courseObjList,
                course= course,
                subtotal=initSubtotal,
            };
            return View(checkoutVM);
        }
    }
}
