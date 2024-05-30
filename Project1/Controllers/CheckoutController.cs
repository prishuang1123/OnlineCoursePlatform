using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;
using Project1.Utilities;
using Project1.ViewModels;

namespace Project1.Controllers
{
    public class CheckoutController : VerifyUserRoles
    {
        private readonly ProjectDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;

        public CheckoutController(ProjectDbContext db, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager) :base (userManager, signInManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index() 
        {
            int memberId=Util.getMemberId(_db, _userManager, User);
            DbSet<Course> course = _db.Course;
            IEnumerable<ShoppingCart>memberShoppingCart = await _db.Cart.Where(u => u.MemberID == memberId).ToListAsync();
            Member memberObj = await _db.Member.Where(obj=>obj.MemberID==memberId).FirstOrDefaultAsync();
            Discount discountObj;
            if (TempData["DiscountCode"] != null)
            {
                discountObj = await _db.Discount.Where(obj => obj.DiscountName == TempData["DiscountCode"].ToString()).FirstOrDefaultAsync();
                TempData.Remove("DiscountCode");
            }
            else
            {
                discountObj = null;
            }
           
            IEnumerable<Location> locationList = await _db.Location.ToListAsync();
            var courseObjList = memberShoppingCart
                .GroupBy(c => c.CourseID)
                .Select(cs => new ShoppingCart 
                {
                    CourseID = cs.Key,
                    Quantity = cs.Sum(c => c.Quantity),
                    
                }).ToList(); 
           
            decimal initSubtotal = 0;
            foreach(var item in courseObjList)
            {
                initSubtotal += (item.Quantity) * (_db.Course.Where(c => c.CourseID == item.CourseID).FirstOrDefault().Price);
            }

            CheckoutVM checkoutVM = new CheckoutVM()
            {
                Member = memberObj,
                Discountobj = discountObj,
                Location = locationList,
                cartItemList= memberShoppingCart,
                courseObjList= courseObjList,
                course= course,
                subtotal=initSubtotal,
            };
            return View(checkoutVM);
        }
        [HttpPost]
        public IActionResult StoreDiscountCode(string discountCode)
        {
            // Store discountCode in TempData
            TempData["DiscountCode"] = discountCode;
            return Json(new { success = true }); // Optionally, return a success response
        }
    }
}
