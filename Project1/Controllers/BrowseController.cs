using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;
using Project1.Data;
using Project1.Models;
using Project1.Utilities;
using Project1.ViewModels;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Security.Claims;

namespace Project1.Controllers
{
    public class BrowseController : VerifyUserRoles
    {
        private readonly ProjectDbContext _db;
        //internal DbSet<Trainer> trainerDbset;
        private int memberId;
        private IEnumerable<ShoppingCart> memberShoppingCart;
        private readonly UserManager<ProjectUser> _userManager;

        public BrowseController(ProjectDbContext db, UserManager<ProjectUser> userManager, SignInManager<ProjectUser> signInManager) : base(userManager, signInManager)
        {
            _db = db;
            _userManager = userManager;
            
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Course>? courseObjList = await _db.Course.ToListAsync();
            IEnumerable<CourseCategory>? categoryObjList = await _db.CourseCategory.ToListAsync();

            //IQueryable<Trainer> queryTrainer = trainerDbset;

            if (courseObjList == null || categoryObjList == null)
            {
                return NotFound();
            }
            BrowseVM? browseVM = new BrowseVM()
            {
                courseList = courseObjList,
                categoryList = categoryObjList,

            };

            return View(browseVM);
        }

        // GET: Browse/Cart/5
        public async Task<IActionResult> ViewCart() //recieve memberID
        {
            //var memberId = Util.getMemberId(_db,_userManager, User);
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var memberId = 0;
            if (userId != null)
            {
                var Mem = _db.Member.Where(m => m.AspID == userId).FirstOrDefault();
                memberId = Mem.MemberID;
            }
            //if (id==null || id == 0)
            //{
            //	return RedirectToAction ("Login", "Members");
            //}

            //Course course= await _db.Course.Where(u=>u.CourseID==id).FirstOrDefaultAsync();
            //select the member's cartItems to show all products added to the cart

            memberShoppingCart = await _db.Cart.Where(u => u.MemberID == memberId).ToListAsync();
            IEnumerable<int> courseIds = memberShoppingCart.Select(u => u.CourseID).ToList();
            List<Course> courseObj = await _db.Course.Where(c => courseIds.Contains(c.CourseID)).ToListAsync();
            var courseObjList = memberShoppingCart
                .GroupBy(c => c.CourseID)
                .Select(cs => new
                {
                    CourseID = cs.Key,
                    Quantity = cs.Sum(c => c.Quantity),
                    CartIdToScheduleDate = cs.Select(c => new { CartID = c.CartID, ScheduleDate = _db.ClassSchedule.Where(s => s.SchedulerID == c.SchedulerID).FirstOrDefault().Scheduler }).ToArray(),

                });

            decimal initSubtotal = 0;
            foreach (var courseId in courseIds)
            {
                initSubtotal += (courseObj.Where(c => c.CourseID == courseId).FirstOrDefault().Price) * (memberShoppingCart.Where(m => m.CourseID == courseId).FirstOrDefault().Quantity);
            }

            CartVM? cartVM = new CartVM()
            {
                memberId = memberId,
                courseList = courseObj,
                shoppingCartList = memberShoppingCart,
                subtotal = initSubtotal,
            };



            if (cartVM != null)
            {

                return View(cartVM);
            }
            else
            {
                return NotFound(); //login page?
            }

        }

        public class AddToCartRequest
        {
            public int CourseID { get; set; }
            public int MemberID { get; set; }
            public List<int> SelectedSchedules { get; set; }
        }


        [HttpPost]
        public async Task<IActionResult> AddToCart([FromBody] AddToCartRequest request)
        {
            if (request == null || request.SelectedSchedules == null || request.SelectedSchedules.Count == 0)
            {
                return BadRequest("No schedules selected");
            }

            var courseObj = await _db.Course.FirstOrDefaultAsync(u => u.CourseID == request.CourseID);
            if (courseObj == null)
            {
                return NotFound();
            }

            foreach (var scheduleID in request.SelectedSchedules)
            {
                var existingCartItem = await _db.Cart
                    .FirstOrDefaultAsync(c => c.CourseID == request.CourseID && c.SchedulerID == scheduleID && c.MemberID == request.MemberID); // 使用实际的 MemberID
                if (existingCartItem != null)
                {
                    return BadRequest("所選時段已在購物車中 不能重複添加相同的課程和時段");
                }
                else
                {
                    var newCartItem = new ShoppingCart
                    {
                        CourseID = request.CourseID,
                        SchedulerID = scheduleID,
                        Quantity = 1,
                        MemberID = request.MemberID, // 使用实际的 MemberID
                    };

                    if (ModelState.IsValid)
                    {
                        _db.Cart.Add(newCartItem);
                    }

                }
            }

            await _db.SaveChangesAsync();
            TempData["success"] = "加入購物車成功!!";

            return RedirectToAction("ViewCart", "Browse");
        }

        public class AddCourseRatingRequest
        {
            public int CourseID { get; set; }
            public int MemberID { get; set; }
            public int Rating { get; set; }
            public int TrainerID { get; set; }
            public string Comment { get; set; }
            
        }

        [HttpPost]
        public async Task<IActionResult> AddCourseRating([FromBody] AddCourseRatingRequest request)
        {
            var hasOrder = await _db.Order
        .AnyAsync(o => o.MemberID == request.MemberID &&
                       _db.OrderDetail.Any(od => od.OrderID == o.OrderID && od.CourseID == request.CourseID));

            if (hasOrder == false)
            {
                return BadRequest(new { message = "無法新增評論 您尚未體驗過此門課程" });
            }

            var hasCommented = await _db.CourseRating
        .AnyAsync(cr => cr.CourseID == request.CourseID && cr.UserID == request.MemberID);

            if (hasCommented)
            {
                return BadRequest(new { message = "您已評論過此門課程，無法重複評論" });
            }
            var course = await _db.Course.FirstOrDefaultAsync(c => c.CourseID == request.CourseID);

            request.TrainerID = course.TrainerID;


            var courseRating = new CourseRating
            {
                CourseID = request.CourseID,
                UserID = request.MemberID,
                Rating = request.Rating,
                Comment = request.Comment,
                TrainerID = request.TrainerID,
                RatingDate = DateTime.Now
            };

            _db.CourseRating.Add(courseRating);
            await _db.SaveChangesAsync();

            return Ok(new { message = "評論新增成功" });
        }

        public async Task<JsonResult> ViewRating(int? id)
        {
            var rating = (from cr in _db.CourseRating
                          join m in _db.Member on cr.UserID equals m.MemberID
                          select new CourseRatingViewModel
                          {
                              CourseRatingID = cr.CourseRatingID,
                              CourseID = cr.CourseID,
                              TrainerID = cr.TrainerID,
                              UserName = m.Name,
                              Rating = cr.Rating,
                              Comment = cr.Comment,
                              RatingDate = cr.RatingDate,
                          }
                         ).Where(c => c.CourseID == id);

            return Json(rating);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FollowItem(int? id) //courseID
        {
            //add the course into the logged in member's cart-> add a data into cart table
            Course? courseObj = await _db.Course.Where(u => u.CourseID == id).FirstOrDefaultAsync();
            if (courseObj != null)
            {
                //List<ShoppingCart> shoppingCartList = await _db.Cart.ToListAsync();
                FollowItem followItem = await _db.FollowItem.Where(obj => obj.CourseID == id).FirstOrDefaultAsync();

                if (followItem == null)
                {
                    FollowItem newFollowItem = new FollowItem();
                    newFollowItem.CourseID = courseObj.CourseID;
                    newFollowItem.MemberID = 1; //later with real memberID

                    if (ModelState.IsValid)
                    {
                        _db.FollowItem.Add(newFollowItem);
                        _db.SaveChanges();
                        TempData["success"] = "成功加入追蹤清單!!";
                        return RedirectToAction("Index", "Browse");
                    }
                    return RedirectToAction("Index", "Browse");
                }
                else
                {
                    TempData["success"] = "商品已在追蹤清單中!!";
                    return RedirectToAction("Index", "Browse");
                }

            }
            else
            {
                return NotFound();
            }


        }

        [HttpGet]
        public JsonResult CategoryNumber()
        {
            var categoryNum = _db.Course.GroupBy(c => c.CourseCategoryID)
            .Select(cn => new
            {
                CourseCategoryID = cn.Key,
                TotalNum = cn.Count(),
                CategoryName = (_db.CourseCategory.FirstOrDefault(c => c.CourseCategoryID == cn.Key)).CourseCategoryName
            });

            //var categoryNumList = new List<object>();
            //foreach (var categoryObj in categoryNum)
            //{
            //	categoryNumList.Add(categoryObj);
            //}
            return Json(categoryNum);
        }
        [HttpGet]
        public JsonResult GetClassSchedule()
        {
            //var memberId = Util.getMemberId(_db, _userManager, User);
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var memberId = 0;
            if (userId != null)
            {
                var Mem = _db.Member.Where(m => m.AspID == userId).FirstOrDefault();
                memberId = Mem.MemberID;
            }
            memberShoppingCart = _db.Cart.Where(u => u.MemberID == memberId).ToList(); //member到時候再改
            var classSchedule = memberShoppingCart
            .GroupBy(c => c.CourseID)
            .Select(cs => new
            {
                CourseID = cs.Key,
                Quantity = cs.Sum(c => c.Quantity), // Total quantity for the course
                SelectedScheduleId = (from cart in _db.Cart
                                      where (cart.CourseID == cs.Key &
                                            cart.MemberID == memberId)
                                      join schedule in _db.ClassSchedule
                                      on cart.SchedulerID equals schedule.SchedulerID
                                      select $"{cart.CourseID}-{cart.SchedulerID}").ToList(),


                SelectedScheduleDate = (from cart in _db.Cart
                                        where (cart.CourseID == cs.Key &
                                            cart.MemberID == memberId)
                                        join schedule in _db.ClassSchedule
                                        on cart.SchedulerID equals schedule.SchedulerID
                                        select new { cart.SchedulerID, schedule.Scheduler })
                            .ToDictionary(x => x.SchedulerID, x => x.Scheduler),

                AllScheduleId = _db.ClassSchedule
                .Where(obj => obj.CourseID == cs.Key)
                .Select(obj => obj.SchedulerID)
                .Distinct()
                .ToList(),
                AllScheduleDate = (from schedule in _db.ClassSchedule
                                   where schedule.CourseID == cs.Key
                                   select new { schedule.SchedulerID, schedule.Scheduler })
                            .ToDictionary(x => x.SchedulerID, x => x.Scheduler),
                //AllScheduleDate = _db.ClassSchedule
                //.Where(obj => obj.CourseID == cs.Key)
                //.Select(obj => obj.Scheduler)
                //.Distinct()
                //.ToList(),
            });


            return Json(classSchedule);
        }

        [HttpPost]
        public IActionResult UpdateQuantity(int quantity, int id)//quantity,cartId
        {
            ShoppingCart cartItem = _db.Cart.Where(obj => obj.CartID == id).FirstOrDefault();
            cartItem.Quantity = quantity;
            _db.SaveChanges();
            //TempData["success"] = "成功更新商品數量!!";
            Course course = _db.Course.Where(c => c.CourseID == cartItem.CourseID).FirstOrDefault();

            decimal totalPrice = (course.Price) * quantity;


            return Json(new { TotalPrice = totalPrice.ToString("c") });
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Delete(int id)//courseId
        {
            List<ShoppingCart> cartItemList = _db.Cart.Where(obj => obj.CourseID == id).ToList();
            int memberId = cartItemList.Any() ? cartItemList[0].MemberID : 0;
            foreach (var cartItem in cartItemList)
			{
                _db.Cart.Remove(cartItem);
                
            }
            _db.SaveChanges();

            TempData["success"] = "商品刪除成功!!";
            //return RedirectToAction("ViewCart", "Browse", new { id = 1 });
            return Json(new { success = true, memberId = memberId });
        }
   
        [HttpGet]
        public async Task<IActionResult> UpdateSubtotal()
        {
            //var memberId = Util.getMemberId(_db, _userManager, User);
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var memberId = 0;
            if (userId != null)
            {
                var Mem = _db.Member.Where(m => m.AspID == userId).FirstOrDefault();
                memberId = Mem.MemberID;
            }
            decimal subtotal = 0;
            memberShoppingCart = await _db.Cart.Where(u => u.MemberID == memberId).ToListAsync();
            IEnumerable<int> courseIds = memberShoppingCart.Select(u => u.CourseID).ToList();
            List<Course> courseObj = await _db.Course.Where(c => courseIds.Contains(c.CourseID)).ToListAsync();
            foreach (var courseId in courseIds)
            {
                subtotal += (courseObj.Where(c => c.CourseID == courseId).FirstOrDefault().Price) * (memberShoppingCart.Where(m => m.CourseID == courseId).FirstOrDefault().Quantity);
            }

            return Json(new { Subtotal = subtotal.ToString("c") });
        }

        [HttpGet]
        public async Task<IActionResult> ValidateDiscountCode(string? discountCode)
        {
            string validationResult = "";
            double discountPercentage = 0;

            Discount discountObj = await _db.Discount.Where(d => d.DiscountName == discountCode).FirstOrDefaultAsync();
            if (discountObj != null)
            {
                DateTime now = DateTime.Now;
                if (discountObj.StartDate < now && now < discountObj.EndDate && discountObj.Active == true)
                {
                    discountPercentage = discountObj.DiscountPercentage;
                    validationResult = "success";
                    TempData["DiscountCode"]=discountObj.DiscountName;
                }
                else
                {
                    discountPercentage = 1;
                    validationResult = "not applicable";
                }

            }
            else
            {
                discountPercentage = 1;
                validationResult = "failed";
            }

            return Json(new { validationResult = validationResult, discountPercentage = discountPercentage });
        }

        //     [HttpPost]
        //     public IActionResult UpdateCartItem(int courseId, int scheduleId, bool isSelected)//update cartItem
        //     {
        //         int memberId = _db.Cart.Where(obj => obj.CourseID == courseId).FirstOrDefault().MemberID;
        //         if (isSelected)
        //{
        //             ShoppingCart cartItem = _db.Cart.Where(obj => obj.SchedulerID == scheduleId).FirstOrDefault();
        //             _db.Remove(cartItem);
        //             _db.SaveChanges();
        //         }
        //else
        //{
        //	ShoppingCart newCartItem = new ShoppingCart();

        //	newCartItem.CourseID = courseId;
        //	newCartItem.SchedulerID = scheduleId;
        //             newCartItem.MemberID=memberId;
        //	newCartItem.Quantity=1;
        //             _db.Add(newCartItem);
        //             _db.SaveChanges();
        //         }

        //         return Json(new { success=true });
        //     }

        [HttpPost]
        public IActionResult UpdateCartItem(int courseId, int scheduleId, bool isSelected)
        {
            try
            {
                //var memberId = Util.getMemberId(_db, _userManager, User);
                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                var memberId = 0;
                if (userId != null)
                {
                    var Mem = _db.Member.Where(m => m.AspID == userId).FirstOrDefault();
                    memberId = Mem.MemberID;
                }


                if (memberId != null)
                {
                    if (isSelected)
                    {//沒選變有選，加到購物車
                        ShoppingCart newCartItem = new ShoppingCart();
                        newCartItem.CourseID = courseId;
                        newCartItem.SchedulerID = scheduleId;
                        newCartItem.MemberID = memberId;
                        newCartItem.Quantity = 1;
                        _db.Add(newCartItem);
                        _db.SaveChanges();
                    }
                    else
                    {//有選變沒選，從購物車移出
                        ShoppingCart cartItem = _db.Cart.FirstOrDefault(obj => obj.SchedulerID == scheduleId);
                        if (cartItem != null)
                        {
                            _db.Remove(cartItem);
                            _db.SaveChanges();
                        }

                    }
					decimal coursePrice = _db.Course.Where(c => c.CourseID == courseId).FirstOrDefault().Price;
					decimal totalPrice = 0;
                    IEnumerable<ShoppingCart> memberShoppingCart = _db.Cart.Where(obj => obj.CourseID == courseId).ToList();
                    foreach (var cartItem in memberShoppingCart)
					{
						if (cartItem.CourseID == courseId)
						{
							totalPrice += coursePrice;
						}
					}
						
                    return Json(new { success = true, TotalPrice=totalPrice});
                }
                else
                {
                    return Json(new { success = false, error = "Member ID not found." });
                }
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                Console.WriteLine(ex.Message);
                return Json(new { success = false, error = ex.Message });
            }
        }
        
    }
}
