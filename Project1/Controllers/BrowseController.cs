using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;

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
    }
}
