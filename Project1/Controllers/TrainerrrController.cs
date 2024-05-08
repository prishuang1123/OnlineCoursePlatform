using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Project1.Data;
using Project1.Models;


namespace Project1.Controllers
{
    public class TrainerrrController : Controller
    {
        private readonly ProjectDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public TrainerrrController(ProjectDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Trainerrr
        public async Task<IActionResult> Index()
        {
            return View(await _context.Course.ToListAsync());
        }
		public async Task<IActionResult> Indexblog()
		{
			return View(await _context.Course.ToListAsync());
		}

		// GET: Trainerrr/Details/5
		public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .FirstOrDefaultAsync(m => m.CourseID == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Trainerrr/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trainerrr/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseID,CourseName,TrainerID,PetCategory,CourseCategory,CourseType,Description,ApprovalStatus,Price,Location,MaxParticipants,EnrollmentCount,CreatedAt,UpdatedAt,Clicks,ThumbnailUrl")] Course course, IFormFile thumbnailFile)
        {
            if (ModelState.IsValid)
            {
                if (thumbnailFile != null && thumbnailFile.Length > 0)
                {
                    // 將上傳的圖片保存到指定文件夾
                    var uploadsFolder = Path.Combine(_environment.WebRootPath, "img/CourseThumbnail");
                    // 生成唯一的文件名
                    var uniqueFileName = Guid.NewGuid().ToString() + "_" + thumbnailFile.FileName;
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await thumbnailFile.CopyToAsync(fileStream);
                    }

                    // 設置課程的 ThumbnailUrl 屬性為保存的文件路徑
                    course.ThumbnailUrl = "/img/CourseThumbnail/" + uniqueFileName;
                }

                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        // GET: Trainerrr/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        // POST: Trainerrr/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseID,CourseName,TrainerID,PetCategory,CourseCategory,CourseType,Description,ApprovalStatus,Price,DiscountID,Location,MaxParticipants,EnrollmentCount,CreatedAt,UpdatedAt,Clicks,ThumbnailUrl")] Course course)
        {
            if (id != course.CourseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.CourseID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        // GET: Trainerrr/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .FirstOrDefaultAsync(m => m.CourseID == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Trainerrr/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Course.FindAsync(id);
            if (course != null)
            {
                _context.Course.Remove(course);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Course.Any(e => e.CourseID == id);
        }
    }
}
