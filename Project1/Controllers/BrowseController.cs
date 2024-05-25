﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using Project1.Data;
using Project1.Models;
using Project1.ViewModels;
using System.Collections.Generic;

namespace Project1.Controllers
{
    public class BrowseController : Controller
    {
		private readonly ProjectDbContext _db;
        //internal DbSet<Trainer> trainerDbset;
        private int? memberId;
		private IEnumerable<ShoppingCart> memberShoppingCart;

        public BrowseController(ProjectDbContext db)
		{
			_db = db;
			//trainerDbset = _db.Set<Trainer>();
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
        public async Task<IActionResult> ViewCart(int? id) //recieve memberID
		{
			//if (id==null || id == 0)
			//{
			//	return RedirectToAction ("Login", "Members");
			//}
			memberId = id;
			//Course course= await _db.Course.Where(u=>u.CourseID==id).FirstOrDefaultAsync();
			//select the member's cartItems to show all products added to the cart
			
			memberShoppingCart = await _db.Cart.Where(u => u.MemberID == 1).ToListAsync();
			IEnumerable<int> courseIds= memberShoppingCart.Select(u => u.CourseID).ToList();
			List<Course> courseObj=await _db.Course.Where(c=>courseIds.Contains(c.CourseID)).ToListAsync();
			var courseObjList = memberShoppingCart
				.GroupBy(c => c.CourseID)
				.Select(cs => new
				{
					CourseID=cs.Key,
					Quantity=cs.Sum(c => c.Quantity),
                    CartIdToScheduleDate = cs.Select(c => new { CartID = c.CartID, ScheduleDate = _db.ClassSchedule.Where(s=>s.SchedulerID==c.SchedulerID).FirstOrDefault().Scheduler }).ToArray(),

                });

            decimal initSubtotal = 0;
            foreach (var courseId in courseIds)
			{
				initSubtotal += (courseObj.Where(c => c.CourseID == courseId).FirstOrDefault().Price) * (memberShoppingCart.Where(m => m.CourseID == courseId).FirstOrDefault().Quantity);
            }

			CartVM? cartVM = new CartVM()
			{
				memberId = (int)memberId,
                courseList = courseObj,
				shoppingCartList= memberShoppingCart,
                subtotal= initSubtotal,
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
                //var existingCartItem = await _db.Cart
                //    .FirstOrDefaultAsync(c => c.CourseID == request.CourseID && c.SchedulerID == scheduleID && c.MemberID == 1); // 使用实际的 MemberID

                    var newCartItem = new ShoppingCart
                    {
                        CourseID = request.CourseID,
                        SchedulerID = scheduleID,
                        Quantity = 1,
                        MemberID = 1 // 使用实际的 MemberID
                    };

                    if (ModelState.IsValid)
                    {
                        _db.Cart.Add(newCartItem);
                    }

                //if (existingCartItem == null)
                //{
                //}
                //else
                //{
                //    existingCartItem.Quantity += 1;
                //    if (ModelState.IsValid)
                //    {
                //        _db.Cart.Update(existingCartItem);
                //    }
                //}
            }

            await _db.SaveChangesAsync();
            TempData["success"] = "加入購物車成功!!";

            return RedirectToAction("ViewCart", "Browse");
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
			memberShoppingCart= _db.Cart.Where(u => u.MemberID == 1).ToList(); //member到時候再改
            var classSchedule = memberShoppingCart
			.GroupBy(c => c.CourseID)
            .Select(cs => new
            {
                CourseID = cs.Key,
                Quantity = cs.Sum(c => c.Quantity), // Total quantity for the course
                SelectedScheduleId = (from cart in _db.Cart
                                      where cart.CourseID == cs.Key
                                      join schedule in _db.ClassSchedule
                                      on cart.SchedulerID equals schedule.SchedulerID
                                      select $"{cart.CourseID}-{cart.SchedulerID}").ToList(),


                SelectedScheduleDate = (from cart in _db.Cart
                                        where cart.CourseID == cs.Key
                                        join schedule in _db.ClassSchedule
                                        on cart.SchedulerID equals schedule.SchedulerID
                                        select new { cart.SchedulerID, schedule.Scheduler })
                            .ToDictionary(x => x.SchedulerID, x => x.Scheduler),
                
                AllScheduleId = _db.ClassSchedule
				.Where(obj=>obj.CourseID== cs.Key)
				.Select(obj=>obj.SchedulerID)
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
			ShoppingCart cartItem = _db.Cart.Where(obj=>obj.CartID==id).FirstOrDefault();
            cartItem.Quantity= quantity;
			_db.SaveChanges();
            //TempData["success"] = "成功更新商品數量!!";
			Course course = _db.Course.Where(c=>c.CourseID==cartItem.CourseID).FirstOrDefault();
			
            decimal totalPrice = (course.Price) * quantity;
            
            
            return Json(new { TotalPrice = totalPrice.ToString("c") });
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Delete(int id)//cartId
        {
            ShoppingCart cartItem = _db.Cart.Where(obj => obj.CartID == id).FirstOrDefault();
            _db.Cart.Remove(cartItem);
            _db.SaveChanges();
			int memberId = cartItem.MemberID;
            TempData["success"] = "商品刪除成功!!";
			//return RedirectToAction("ViewCart", "Browse", new { id = 1 });
			return Json(new { success = true, memberId = memberId });
		}

        [HttpGet]
        public async Task<IActionResult> UpdateSubtotal()
        {
			decimal subtotal = 0;
            memberShoppingCart = await _db.Cart.Where(u => u.MemberID == 1).ToListAsync();
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

            Discount discountObj=await _db.Discount.Where(d=>d.DiscountName == discountCode).FirstOrDefaultAsync();
			if (discountObj != null)
			{
                DateTime now = DateTime.Now;
                if (discountObj.StartDate < now && now < discountObj.EndDate && discountObj.Active==true)
				{
                    discountPercentage = discountObj.DiscountPercentage;
                    validationResult = "success";
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

			return Json(new { validationResult = validationResult, discountPercentage= discountPercentage });
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

                int memberId = (int)(_db.Cart.FirstOrDefault(obj => obj.CourseID == courseId)?.MemberID);

                if (memberId != null)
                {
                    if (isSelected)
                    {//沒選便有選，加到購物車
                        ShoppingCart newCartItem = new ShoppingCart();
                        newCartItem.CourseID = courseId;
                        newCartItem.SchedulerID = scheduleId;
                        newCartItem.MemberID = memberId;
                        newCartItem.Quantity = 1;
                        _db.Add(newCartItem);
                        _db.SaveChanges();
                    }
                    else
                    {//有選便沒選，從購物車移出
                        ShoppingCart cartItem = _db.Cart.FirstOrDefault(obj => obj.SchedulerID == scheduleId);
                        if (cartItem != null)
                        {
                            _db.Remove(cartItem);
                            _db.SaveChanges();
                        }
                        
                    }

                    return Json(new { success = true });
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
