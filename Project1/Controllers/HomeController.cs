using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Project1.Data;
using Project1.DTO;
using Project1.Models;
using Project1.ViewModel;
using Project1.ViewModels;
using System.Diagnostics;

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
            var quantityTotals = _ProjectDbContext.OrderDetail
                .GroupBy(x => x.CourseID)
                .Select(g => new { CourseID = g.Key, TotalQuantity = g.Sum(x => x.Quantity) }); // 將結果轉換為 List

            var courses = (from c in _ProjectDbContext.Course
                           join cr in _ProjectDbContext.CourseRating on c.CourseID equals cr.CourseID into joined
                           let totalQuantityRecord = quantityTotals.FirstOrDefault(q => q.CourseID == c.CourseID)
                           let totalQuantity = totalQuantityRecord != null ? totalQuantityRecord.TotalQuantity : 0
                           let averageRating = joined.GroupBy(r => r.CourseID)
                                         .Select(g => g.Average(r => r.Rating))
                                         .FirstOrDefault()
                           select new CourseRankViewModel
                           {
                               CourseID = c.CourseID,
                               TrainerID = c.TrainerID,
                               Clicks = c.Clicks,
                               TotalQuantity = totalQuantity,
                               CourseAverageRating = Math.Round(averageRating, 2)
                           }); // 將 LINQ to Entities 轉換為 LINQ to Objects

            return View(courses);
        }

		public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Members() //api測試畫面
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
