using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;
using Project1.Utilities;
using Project1.ViewModels;
using System.Security.Claims;

namespace Project1.Controllers
{
    public class CheckoutController : VerifyUserRoles
    {
        private readonly ProjectDbContext _db;
        private readonly UserManager<ProjectUser> _userManager;

        public CheckoutController(ProjectDbContext db, UserManager<ProjectUser> userManager, SignInManager<ProjectUser> signInManager) :base (userManager, signInManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index(String code) 
        {
            //int memberId=Util.getMemberId(_db, _userManager, User);
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var memberId = 0;
            if (userId != null)
            {
                var Mem = _db.Member.Where(m => m.AspID == userId).FirstOrDefault();
                memberId = Mem.MemberID;
            }
            DbSet<Course> course = _db.Course;
            IEnumerable<ShoppingCart>memberShoppingCart = await _db.Cart.Where(u => u.MemberID == memberId).ToListAsync();
            Member memberObj = await _db.Member.Where(obj=>obj.MemberID==memberId).FirstOrDefaultAsync();
            double discountPercentage = 1;
            if (code != null)
            {
                discountPercentage =  _db.Discount.Where(obj => obj.DiscountName == code).FirstOrDefault().DiscountPercentage;
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
                discountPercentage = discountPercentage,
                Location = locationList,
                cartItemList= memberShoppingCart,
                courseObjList= courseObjList,
                course= course,
                subtotal=initSubtotal,
            };
            return View(checkoutVM);
            TempData["courseObjList"] = courseObjList;
        }
        [HttpPost]
        public IActionResult StoreAlreadyUsedDiscountCode(string discountCode)
        {
            Discount discount = _db.Discount.Where(obj => obj.DiscountName == discountCode).FirstOrDefault();
            discount.DiscountName = "used";
            _db.Update(discount);
            _db.SaveChangesAsync();
            return Json(new { success = true }); // Optionally, return a success response
        }
    }
}
