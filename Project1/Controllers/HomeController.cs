using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Project1.Data;
using Project1.DTO;
using Project1.Migrations;
using Project1.Models;
using Project1.ViewModel;
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
                           join cr in _ProjectDbContext.CourseRating on c.CourseID equals cr.CourseID into joined
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
            ).Take(5);

            return Json(courses);
        }

        public async Task<JsonResult> GetAverageRating()
        {
            var quantityTotals = _ProjectDbContext.OrderDetail
                .GroupBy(x => x.CourseID)
                .Select(g => new { CourseID = g.Key, TotalQuantity = g.Sum(x => x.Quantity) }); // 將結果轉換為 List

            var courses = (from c in _ProjectDbContext.Course
                           join cr in _ProjectDbContext.CourseRating on c.CourseID equals cr.CourseID into joined
                           let totalQuantityRecord = quantityTotals.FirstOrDefault(q => q.CourseID == c.CourseID)
                           let totalQuantity = totalQuantityRecord != null ? totalQuantityRecord.TotalQuantity : 0
                           let top5 = totalQuantity
                           let averageRating = joined.GroupBy(r => r.CourseID)
                                         .Select(g => g.Average(r => r.Rating)).FirstOrDefault()
                           select new CourseRankViewModel
                           {
                               CourseID = c.CourseID,
                               TrainerID = c.TrainerID,
                               Clicks = c.Clicks,
                               TotalQuantity = totalQuantity,
                               CourseAverageRating = Math.Round(averageRating, 2),
                               ThumbnailUrl = c.ThumbnailUrl,
                               CourseName = c.CourseName,
                               Description = c.Description
                           }
            );

            return Json(courses);
        }


        public IActionResult Privacy()
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
