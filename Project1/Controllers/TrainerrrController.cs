using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using Project1.Data;
using Project1.Models;
using Project1.ViewModels;
using static Project1.Controllers.TrainerrrController;



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

        // 辅助方法：根据课程类别ID获取课程类别名称
        private async Task<string> GetCourseCategoryName(int courseCategoryId)
        {
            var courseCategoryName = await _context.CourseCategory
                .Where(cc => cc.CourseCategoryID == courseCategoryId)
                .Select(cc => cc.CourseCategoryName)
                .FirstOrDefaultAsync();

            return courseCategoryName;
        }

        // 辅助方法：根据位置ID获取位置名称
        private async Task<string> GetLocationName(int locationId)
        {
            var locationName = await _context.Location
                .Where(l => l.LocationID == locationId)
                .Select(l => l.LocationName)
                .FirstOrDefaultAsync();

            return locationName;
        }

        // GET: Trainerrr
        //課程
        public async Task<IActionResult> Index()
        {


            return View(await _context.Course.ToListAsync());
        }

        // 搜尋動作方法，接收搜尋字串並返回搜尋結果的部分視圖
        public IActionResult Search(string searchString)
        {
            // 從資料庫中獲取所有課程
            var courses = _context.Course.ToList();

            // 如果搜尋字串不為空
            if (!string.IsNullOrEmpty(searchString))
            {
                // 使用 LINQ 查詢，過濾出課程名稱中包含搜尋字串的課程
                courses = courses.Where(c => c.CourseName.Contains(searchString)).ToList();
            }

            // 返回包含搜尋結果的部分視圖 "_CourseListPartial"
            return PartialView("_CourseListPartial", courses);
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
            ViewBag.CourseCategoryName = await GetCourseCategoryName(course.CourseCategoryID);
            ViewBag.LocationName = await GetLocationName(course.LocationID ?? 0); // 使用 0 或其他默认值
            return View(course);
        }

        // GET: Trainerrr/Create
        //訓練師課程新增
        public IActionResult Create()
        {
            var course = new Course();
            //// 準備下拉選單的選項
            ViewBag.CourseCategoryID = new SelectList(_context.CourseCategory, "CourseCategoryID", "CourseCategoryName", course.CourseCategoryID);
            ViewBag.LocationID = new SelectList(_context.Location, "LocationID", "LocationName", course.LocationID);

            return View();
        }
        // POST: Trainerrr/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseID,CourseName,TrainerID,PetCategory,CourseCategoryID,CourseType,Description,ApprovalStatus,Price,LocationID,MaxParticipants,EnrollmentCount,CreatedAt,UpdatedAt,Clicks,ThumbnailUrl")] Course course, IFormFile thumbnailFile)
        {
            if (ModelState.IsValid)
            {
                course.CreatedAt = DateTime.Now;
                if (thumbnailFile != null && thumbnailFile.Length > 0)
                {
                    var uploadsFolder = Path.Combine(_environment.WebRootPath, "img/CourseThumbnail");
                    var uniqueFileName = Guid.NewGuid().ToString() + "_" + thumbnailFile.FileName;
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await thumbnailFile.CopyToAsync(fileStream);
                    }

                    course.ThumbnailUrl = "img/CourseThumbnail/" + uniqueFileName;
                }
                else
                {
                    course.ThumbnailUrl = "img/CourseThumbnail/noimage.jpg";
                }

                try
                {
                    _context.Add(course);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saving course: {ex.Message}");
                }
            }
            else
            {
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        Console.WriteLine($"Validation error: {error.ErrorMessage}");
                    }
                }
            }

            ViewBag.CourseCategoryID = new SelectList(_context.CourseCategory, "CourseCategoryID", "CourseCategoryName", course.CourseCategoryID);
            ViewBag.LocationID = new SelectList(_context.Location, "LocationID", "LocationName", course.LocationID);

            return View(course);
        }



        // GET: Trainerrr/Edit/5
        [HttpGet]
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

            // 准备下拉选项
            ViewBag.CourseCategoryID = new SelectList(_context.CourseCategory, "CourseCategoryID", "CourseCategoryName", course.CourseCategoryID);
            ViewBag.LocationID = new SelectList(_context.Location, "LocationID", "LocationName", course.LocationID);

            return View(course);
        }

        // POST: Trainerrr/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // POST: Trainerrr/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseID,CourseName,TrainerID,PetCategory,CourseCategoryID,CourseType,Description,ApprovalStatus,Price,LocationID,MaxParticipants,EnrollmentCount,CreatedAt,UpdatedAt,Clicks,ThumbnailUrl")] Course course, IFormFile thumbnailFile)
        {

            if (id != course.CourseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                course.UpdatedAt = DateTime.Now;
                try
                {
                    // 如果上传了新的缩略图文件，则保存到指定文件夹并更新缩略图URL
                    if (thumbnailFile != null && thumbnailFile.Length > 0)
                    {
                        var uploadsFolder = Path.Combine(_environment.WebRootPath, "img/CourseThumbnail");
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + thumbnailFile.FileName;
                        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await thumbnailFile.CopyToAsync(fileStream);
                        }

                        // 更新缩略图URL
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

            // 如果 ModelState 验证失败，重新加载下拉选项
            ViewBag.CourseCategoryID = new SelectList(_context.CourseCategory, "CourseCategoryID", "CourseCategoryName", course.CourseCategoryID);
            ViewBag.LocationID = new SelectList(_context.Location, "LocationID", "LocationName", course.LocationID);

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


        //GET:Trainerrr/GetPicture
        //public async Task<FileResult> GetPicture(int id)
        //{
        //    Course c = await _context.Course.FindAsync(id);
        //    string? content = c?.ThumbnailUrl;
        //    return File(content, "image/jpeg");



        //}
        public async Task<FileResult> GetPicture(int id)
        {
            Course course = await _context.Course.FindAsync(id);
            if (course == null || string.IsNullOrEmpty(course.ThumbnailUrl))
            {
                // 返回預設圖片
                string defaultPath = Path.Combine(_environment.WebRootPath, "img/CourseThumbnail/noimage.jpg");
                return PhysicalFile(defaultPath, "image/jpeg");
            }

            string filePath = Path.Combine(_environment.WebRootPath, course.ThumbnailUrl);
            return PhysicalFile(filePath, "image/jpeg");
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
        //---------------------------------------------------------------------------------------------
        public async Task<IActionResult> TrainerCourse()
        {
            return View(await _context.Course.ToListAsync());
        }

        //---------------------------顯示部落格首頁------------------------------------------------

        
        public async Task<IActionResult> Indexblog()
        {
            // 取得當前登入的訓練師
            var currentTrainer = GetCurrentTrainer();

            // 取得該訓練師的所有部落格文章
            //var blogPosts = await _context.Blog.Where(b => b.TrainerID == currentTrainer.TrainerID).ToListAsync();

            // 返回部落格首頁視圖，並傳遞部落格文章列表
            return View();
        }

        // 取得當前登入的訓練師
       //哪個訓練師登入?
        private Trainer GetCurrentTrainer()
        {
            // 這裡示範一個假設的方法，根據你的身份驗證機制來取得當前登入的訓練師
            var trainerId = 1; // 假設訓練師ID為1
            return _context.Trainer.FirstOrDefault(t => t.TrainerID == trainerId);
        }

        public async Task<JsonResult> GetBlog()
        {
            // 取得當前登入的訓練師
            var currentTrainer = GetCurrentTrainer();

            var blogs = await _context.Blog
                                      .Include(b => b.Trainer)
                                      .Where(b => b.TrainerID == currentTrainer.TrainerID)
                                      .ToListAsync();

            var blogPosts = blogs.Select(b => new
            {
                b.BlogID,
                b.TrainerID,
                b.Title,
                b.Content,
                b.Image1,
                b.Image2,
                b.PostedDate,
                TrainerName = b.Trainer.TrainerName
            }).ToList();

            // 返回 JSON 結果
            return Json(blogs);
        }

        //處理發文
        [HttpPost]
        public async Task<IActionResult> CreateBlog([FromBody] Blog newBlog)
        {
            if (ModelState.IsValid)
            {
                newBlog.TrainerID = GetCurrentTrainer().TrainerID; // 設定當前登入的訓練師ID
                newBlog.PostedDate = DateTime.Now;
                _context.Blog.Add(newBlog);
                await _context.SaveChangesAsync();
                return Ok(newBlog);
            }
            return BadRequest(ModelState);
        }
        //---------------------------------------------------------------------------------------------
   
        //訓練師總覽頁面
        public IActionResult AllTrainers()
        {
            return View();
        }

        //取得所有訓練師的資料
        public async Task<JsonResult> getTrainers()
        {
            var trainers = (from t in _context.Trainer
                            join s in _context.Specialization on t.SpecializationID equals s.SpecializationID into joined
                            from s in joined.DefaultIfEmpty() 
                            let specializationName = s != null ? s.SpecializationName : null 
                            select new TrainerViewModel
                            {
                                TrainerID = t.TrainerID,
                                TrainerName = t.TrainerName,
                                Experience = t.Experience,
                                Photo = t.Photo,
                                Qualifications = t.Qualifications,
                                SpecializationName = specializationName 
                            }).ToList(); 
            return Json(trainers);

        }

    }
}
   

