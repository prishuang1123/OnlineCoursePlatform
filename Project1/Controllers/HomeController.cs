using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Project1.Data;
using Project1.Migrations;
using Project1.Models;
using Project1.ViewModels;
using System.Diagnostics;
using System.Linq;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProjectDbContext _ProjectDbContext;

        public HomeController(ILogger<HomeController> logger, ProjectDbContext ProjectDbConext)
        {
            _logger = logger;
            _ProjectDbContext = ProjectDbConext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> GetQuantity()
        {
            var quantityTotals = _ProjectDbContext.OrderDetail
                .GroupBy(x => x.CourseID)
                .Select(g => new { CourseID = g.Key, TotalQuantity = g.Sum(x => x.Quantity) }); // 將結果轉換為 List

            var courses = (from c in _ProjectDbContext.Course
                           let totalQuantityRecord = quantityTotals.FirstOrDefault(g => g.CourseID == c.CourseID)
                           let totalQuantity = totalQuantityRecord != null ? totalQuantityRecord.TotalQuantity : 0
                           orderby totalQuantity descending
                           select new CourseRankViewModel
                           {
                               CourseID = c.CourseID,
                               TrainerID = c.TrainerID,
                               TotalQuantity = totalQuantity,
                               ThumbnailUrl = c.ThumbnailUrl,
                               CourseName = c.CourseName,
                               Description = c.Description
                           }
            ).Take(6);

            return Json(courses);
        }

        public async Task<JsonResult> GetAverageRating()
        { 

            var courses = (from c in _ProjectDbContext.Course
                           join cr in _ProjectDbContext.CourseRating on c.CourseID equals cr.CourseID into joined
                           let averageRating = joined.GroupBy(r => r.CourseID)
                                         .Select(g => g.Average(r => r.Rating)).FirstOrDefault()
                           orderby averageRating descending
                           select new CourseRankViewModel
                           {
                               CourseID = c.CourseID,
                               TrainerID = c.TrainerID,
                               CourseAverageRating = Math.Round(averageRating, 2),
                               ThumbnailUrl = c.ThumbnailUrl,
                               CourseName = c.CourseName,
                               Description = c.Description
                           }
            ).Take(6);

            return Json(courses);
        }

        public async Task<JsonResult> GetClicks()
        {

            var courses = (from c in _ProjectDbContext.Course
                           
                           orderby c.Clicks descending
                           select new CourseRankViewModel
                           {
                               CourseID = c.CourseID,
                               TrainerID = c.TrainerID,
                               ThumbnailUrl = c.ThumbnailUrl,
                               CourseName = c.CourseName,
                               Description = c.Description,
                               Clicks = c.Clicks,
                           }
            ).Take(6);

            return Json(courses);
        }

        public IActionResult Searchtrainers(string searchTerm)
        {
            // 查询 Trainer 表中匹配 TrainerName 的数据
            var trainers = _ProjectDbContext.Trainer.Where(t => t.TrainerName.Contains(searchTerm)).ToList();
            var courses = _ProjectDbContext.Course.Where(t => t.CourseName.Contains(searchTerm)).ToList();
            var location = _ProjectDbContext.Location.FirstOrDefault(t => t.LocationName.Contains(searchTerm));
            var category = _ProjectDbContext.CourseCategory.FirstOrDefault(t => t.CourseCategoryName.Contains(searchTerm));
            var specialization = _ProjectDbContext.Specialization.ToList();
            var petcategory = _ProjectDbContext.PetCategory.ToList();
            var courseType = _ProjectDbContext.CourseType.ToList();
            var courseCategory = _ProjectDbContext.CourseCategory.ToList();
            if(location != null)
            {
                var locationID = location.LocationID;
                courses = _ProjectDbContext.Course.Where(t => t.LocationID == locationID).ToList();
            }
            if(category != null)
            {
                var categoryID = category.CourseCategoryID;
                courses = _ProjectDbContext.Course.Where(t => t.CourseCategoryID == categoryID).ToList();
            }
            var viewmodel = new SearchViewModel
            {
                trainers = trainers,
                courses = courses,
                specializations = specialization,
                petCategories = petcategory,
                courseTypes = courseType,
                courseCategories = courseCategory
            };

            // 返回部分视图，并将查询结果传递给视图
            return PartialView("_SearchResults", viewmodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //�t�κ޲z���s��|�����յe��
        public IActionResult Member()
        {
            return View();
        }
        //���U�e��
        public IActionResult Register()
        {
            return View();
        }

        //�t�κ޲z���s��|��(�Y�a�s��e��)
        public IActionResult MemberVueSPA()
        {
            return View();
        }

        



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
