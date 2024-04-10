using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;

namespace Project1.Controllers
{
	[Route("/Course/{action=Index}/{CourseID?}")]
	public class TrainerController : Controller
    {
        private readonly ILogger<TrainerController> _logger;
        private readonly ProjectDbContext _projectDbContext;

        public TrainerController(ILogger<TrainerController> logger, ProjectDbContext projectDbContext) 
        {
            _logger = logger;
            _projectDbContext = projectDbContext;   
        
        }
        //public IActionResult Index()
        //{
        //    return View(_projectDbContext.Trainer);
        //}
        public IActionResult Index()
        {
            var courses = _projectDbContext.Course.ToList(); // 根據您的代碼邏輯，可能不完全相同
            return View(courses);
        }

        // GET: Course/Details/5
        public async Task<IActionResult> Details(string CourseID)
        {
            if (CourseID == null)
            {
                return NotFound();
            }

            var Course = await _projectDbContext.Trainer
                .FirstOrDefaultAsync(m => m.CourseID == CourseID);
            if (Course == null)
            {
                return NotFound();
            }

            return View(Course);
        }
        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Customers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                _projectDbContext.Add(course);
                _projectDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        // GET: Course/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = _projectDbContext.Trainer.Find(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        // POST: Course/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Course course)
        {
            if (id != course.CourseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _projectDbContext.Update(course);
                _projectDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        // GET: Course/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = _projectDbContext.Trainer.Find(id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var course = _projectDbContext.Trainer.Find(id);
            if (course == null)
            {
                return NotFound();
            }

            _projectDbContext.Trainer.Remove(course);
            _projectDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}