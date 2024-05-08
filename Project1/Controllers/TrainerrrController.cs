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
        //課程
        public async Task<IActionResult> Index()
        {
            return View(await _context.Course.ToListAsync());
        }


        //訓練師部落格
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
                    course.ThumbnailUrl = "img/CourseThumbnail/" + uniqueFileName;
                }

                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        // GET: Trainerrr/Edit/5
        [HttpGet] // 添加此行
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
        public async Task<IActionResult> Edit(int id, [Bind("CourseID,CourseName,TrainerID,PetCategory,CourseCategory,CourseType,Description,ApprovalStatus,Price,DiscountID,Location,MaxParticipants,EnrollmentCount,CreatedAt,UpdatedAt,Clicks,ThumbnailUrl")] Course course, IFormFile thumbnailFile)
        {
            if (id != course.CourseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (thumbnailFile != null && thumbnailFile.Length > 0)
                    {
                        // 将上传的图片保存到指定文件夹
                        var uploadsFolder = Path.Combine(_environment.WebRootPath, "img/CourseThumbnail");
                        // 生成唯一的文件名
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + thumbnailFile.FileName;
                        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await thumbnailFile.CopyToAsync(fileStream);
                        }

                        // 设置课程的ThumbnailUrl属性为保存的文件路径
                        course.ThumbnailUrl = "img/CourseThumbnail/" + uniqueFileName;
                    }

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


        //----------------------------------------------------------------------------------------------------------------------
        // GET: Trainerrr
        // Trainer 審核首頁
        public async Task<IActionResult> TrainerIndex()
        {
            return View(await _context.Trainer.ToListAsync());
        }

        // POST: Trainer/ChangeApprovalStatus首頁審核按鈕
        [HttpPost]
        public async Task<IActionResult> ChangeApprovalStatus(int trainerId, string newStatus)
        {
            var trainer = await _context.Trainer.FindAsync(trainerId);

            if (trainer == null)
            {
                return NotFound();
            }

            trainer.Status = newStatus; // 將訓練師的狀態更新為新的狀態
            await _context.SaveChangesAsync(); // 將變更保存到資料庫

            return RedirectToAction(nameof(TrainerIndex)); // 返回訓練師列表頁面
        }
        public class Trainerrr
        { 
            //文字顏色
            public string GetStatusClass(string status)
        {
            
            if (status == "通過")
            {
                return "status-pass";
            }
            else if (status == "未通過")
            {
                return "status-fail";
            }
            else
            {
                // 如果狀態不是 "通過" 或 "未通過"，返回空字符串或默認類
                return "";
            }
        }
}
        // GET: Trainerrr/TrainerDetail檢視/5
        public async Task<IActionResult> TrainerDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainer = await _context.Trainer.FirstOrDefaultAsync(m => m.TrainerID == id);
            if (trainer == null)
            {
                return NotFound();
            }

            return View(trainer);
        }

        // POST: Trainer/ChangeApprovalStatus首頁審核按鈕
        [HttpPost]
        public async Task<IActionResult> TrainerDetailsbtn(int trainerId, string newStatus)
        {
            var trainer = await _context.Trainer.FindAsync(trainerId);

            if (trainer == null)
            {
                return NotFound();
            }

            trainer.Status = newStatus; // 更新訓練師的審核狀態
            await _context.SaveChangesAsync(); // 將變更保存到資料庫

            return RedirectToAction(nameof(TrainerDetails), new { id = trainerId }); // 重定向回 TrainerDetails 頁面
        }


        // POST: Trainerrr/EditTrainer/5
        // 处理编辑 Trainer 的 POST 请求
        // 为了防止 overposting 攻击，请启用你想要绑定的特定属性
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditTrainer(int id, [Bind("TrainerID,MemberID,TrainerName,Specialization,Experience,Qualifications,Status,Photo")] Trainer trainer)
        {
            if (id != trainer.TrainerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trainer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainerExists(trainer.TrainerID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(TrainerIndex)); // 這裡是重定向到 TrainerIndex
            }
            return View(trainer);
        }

        private bool TrainerExists(int id)
        {
            return _context.Trainer.Any(e => e.TrainerID == id);
        }
    }
}

   
