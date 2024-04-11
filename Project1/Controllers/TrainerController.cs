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

        //新增
        // GET: Course/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST:Course/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseID,CourseName,TrainerID,PetCategory,CourseCategory,CourseType,Description,ApprovalStatus,Price,DiscountID,Location,MaxParticipants,EnrollmentCount,CreatedAt,UpdatedAt,Clicks")] Course course)
        {
            if (ModelState.IsValid)
            {
                _projectDbContext.Add(course);
                await _projectDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        //編輯
        // GET: Course/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course =await _projectDbContext.Course.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        // POST: Course/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseID,CourseName,TrainerID,PetCategory,CourseCategory,CourseType,Description,ApprovalStatus,Price,DiscountID,Location,MaxParticipants,EnrollmentCount,CreatedAt,UpdatedAt,Clicks")] Course course)
        {
            if (id != course.CourseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _projectDbContext.Update(course);//有值就updata到customer
                    await _projectDbContext.SaveChangesAsync();//回傳到資料庫
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(course.CourseID))
                    {
                        return NotFound();//如果id不存在就notfound
                    }
                    else
                    {
                        throw;//如果不是不存在的問題就拋回上一層的呼叫
                    }
                }
                return RedirectToAction(nameof(Index));//如果更新成功就回到Index
            }
            return View(course);
        }

        // GET: Course/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course =await _projectDbContext.Course.FindAsync(id);
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
            var course = _projectDbContext.Course.Find(id);
            if (course == null)
            {
                return NotFound();
            }

            _projectDbContext.Course.Remove(course); // Corrected to remove from Course entity set
            _projectDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        private bool CustomerExists(int id)
        {
            return _projectDbContext.Trainer.Any(e => int.Parse(e.CourseID) == id);
        }
    }
}