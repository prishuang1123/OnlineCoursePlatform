using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using Project1.Data;
using Project1.Models;
using Project1.ViewModels;

namespace Project1.Controllers
{
    public class BrowseController : Controller
    {
		private readonly ProjectDbContext _db;
		internal DbSet<Trainer> trainerDbset;
		public BrowseController(ProjectDbContext db)
		{
			_db = db;
			trainerDbset = _db.Set<Trainer>();
		}
		public async Task<IActionResult> Index()
        {
			IEnumerable<Course>? courseObjList = await _db.Course.ToListAsync();
			IEnumerable<CourseCategory>? categoryObjList = await _db.CourseCategory.ToListAsync();

			IQueryable<Trainer> queryTrainer = trainerDbset;

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
            //Course course= await _db.Course.Where(u=>u.CourseID==id).FirstOrDefaultAsync();
            //select the member's cartItems to show all products added to the cart
            IEnumerable<ShoppingCart>? memberCartItemList=await _db.Cart.Where(u=>u.MemberID == 1).ToListAsync();
			

			if (memberCartItemList != null)
			{
				
				return View(memberCartItemList);
			}
			else
			{
				return NotFound(); //login page?
			}

		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AddToCart(int? id) //courseID
		{
			//add the course into the logged in member's cart-> add a data into cart table
			Course? courseObj = await _db.Course.Where(u=>u.CourseID == id).FirstOrDefaultAsync();
			if (courseObj != null)
			{
				ShoppingCart cartItem = new ShoppingCart();
				cartItem.CourseID = courseObj.CourseID;
				cartItem.Quantity = 1;
				cartItem.MemberID = 1; //later with real memberID

				if (ModelState.IsValid)
                {
                    _db.Cart.Add(cartItem);
                    _db.SaveChanges();
                    TempData["success"] = "加入購物車成功!!";
                    return RedirectToAction("ViewCart", "Browse");
                }
                return RedirectToAction("Index", "Browse");
            }
			else
			{
                return NotFound();
            }
			
			
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> FollowItem(int? id) //courseID
		{
			//add the course into the logged in member's cart-> add a data into cart table
			Course? courseObj = await _db.Course.Where(u => u.CourseID == id).FirstOrDefaultAsync();
			if (courseObj != null)
			{
				FollowItem followItem = new FollowItem();
				followItem.CourseID = courseObj.CourseID;
				followItem.MemberID = 1; //later with real memberID

				if (ModelState.IsValid)
				{
					_db.FollowItem.Add(followItem);
					_db.SaveChanges();
					TempData["success"] = "加入追蹤清單!!";
					return RedirectToAction("Index", "Browse");
				}
				return RedirectToAction("Index", "Browse");
			}
			else
			{
				return NotFound();
			}


		}

		public async Task<JsonResult> CategoryNumber()
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
	}
}
