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
            Member memberObj = await _db.Member.Where(obj=>obj.MemberID==id).FirstOrDefaultAsync();
            Discount discountObj = await _db.Discount.Where(obj=>obj.DiscountName==discountCode).FirstOrDefaultAsync();
            IEnumerable<Location> locationList = await _db.Location.ToListAsync();
            IEnumerable<ShoppingCart> cartItemList = await _db.Cart.ToListAsync();

            //public Member Member { get; set; }
            //public Discount Discount { get; set; }
            //public Order Order { get; set; }
            //public OrderDetail OrderDetail { get; set; }
            //public Payment Payment { get; set; }
            //IEnumerable<Location> Location { get; set; }
            CheckoutVM checkoutVM = new CheckoutVM()
            {
                Member = memberObj,
                Discount = discountObj,
                Location = locationList,
                cartItemList=cartItemList,
            };
            return View(checkoutVM);
        }
    }
}
