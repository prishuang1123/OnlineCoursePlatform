using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using Newtonsoft.Json;
using Project1.Data;
using Project1.Models;
using Project1.ViewModels;
using static Project1.Controllers.TrainerrrController;



namespace Project1.Controllers
{
    public class TrainerrrController : VerifyUserRoles
    {
        private readonly UserManager<ProjectUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly ProjectDbContext _context;
        private readonly IWebHostEnvironment _environment;
        private readonly IConfiguration _Configuration;

        public TrainerrrController(ProjectDbContext context, IWebHostEnvironment environment, UserManager<ProjectUser> userManager, SignInManager<ProjectUser> signInManager, RoleManager<ApplicationRole> roleManager, IConfiguration configuration) : base(userManager, signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
            _environment = environment;
            _Configuration = configuration;
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
        public async Task<FileResult> GetPicture(int? id)
        {
            var course = _context.Course.Find(id);
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

        //// POST: Trainer/ChangeApprovalStatus首頁審核按鈕
        //[HttpPost]
        //public async Task<IActionResult> ChangeApprovalStatus(int trainerId, string newStatus)
        //{
        //    var trainer = await _context.Trainer.FindAsync(trainerId);

        //    if (trainer == null)
        //    {
        //        return NotFound();
        //    }

        //    trainer.Status = newStatus; // 將訓練師的狀態更新為新的狀態
        //    await _context.SaveChangesAsync(); // 將變更保存到資料庫

        //    return RedirectToAction(nameof(TrainerIndex)); // 返回訓練師列表頁面
        //}

        //wayne:給予用戶訓練師權限功能
        [HttpPost]
        [Authorize(Roles = "Admin")] // 限制只有具有 Admin 角色的用戶可以訪問此方法
        public async Task<IActionResult> ChangeApprovalStatus(int trainerId, string newStatus)
        {
            var trainer = await _context.Trainer.FindAsync(trainerId);

            if (trainer == null)
            {
                return NotFound();
            }

            trainer.Status = newStatus; // 將訓練師的狀態更新為新的狀態

            
            // 使用 MemberID 查找 Member 記錄
            var member = await _context.Member.FirstOrDefaultAsync(m => m.MemberID == trainer.MemberID);
            if (member != null)
            {
                    // 使用 AspID 作為 UserId 來查找用戶
                var user = await _userManager.FindByIdAsync(member.AspID);
                if (user != null)
                {
                    if(newStatus == "通過")
                    {
                        var result = await _userManager.AddToRoleAsync(user, "Trainer");
                        if (!result.Succeeded)
                        {
                            member.IsTrainer = true;
                            _context.Member.Update(member);
                        }
                        else
                        {
                            ModelState.AddModelError("", "Failed to add user to Trainer role");
                            return RedirectToAction(nameof(TrainerIndex));
                        }
                    }
                    else if (newStatus == "未通過")
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, "Trainer");
                        if (result.Succeeded)
                        {
                            member.IsTrainer = false;
                            _context.Member.Update(member);
                        }
                        else
                        {
                            ModelState.AddModelError("", "Failed to remove user from Trainer role");
                            return RedirectToAction(nameof(TrainerIndex));
                        }
                    }
                }
            }
            
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

        //---------------------------顯示部落格首頁----------------------------
        public async Task<IActionResult> Indexblog()
        {
            // 取得當前登入的訓練師
            var currentTrainer = GetCurrentTrainer();


            // 返回部落格首頁視圖，並傳遞部落格文章列表
            return View();
        }



        // 取得當前登入的訓練師
        //哪個訓練師登入?
        private Trainer GetCurrentTrainer()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value; // 取得當前登錄的使用者 ID
            if (userId == null)
            {
                return null; // 如果沒有找到使用者 ID，返回 null
            }

            var member = _context.Member.FirstOrDefault(m => m.AspID == userId); // 根據 AspID 查找 Member
            if (member == null)
            {
                return null; // 如果沒有找到 Member，返回 null
            }

            return _context.Trainer.FirstOrDefault(t => t.MemberID == member.MemberID); // 根據 MemberID 查找 Trainer
        }


        //訓練師是誰?

        //[HttpGet("GetCurrentTrainer")]
        public JsonResult GetCurrentTrainerInfo()
        {
            var currentTrainer = GetCurrentTrainer();
            if (currentTrainer == null)
            {
                return Json(new { success = false, message = "請重新登入訓練師" });
            }
            return Json(new
            {
                success = true,
                trainerName = currentTrainer.TrainerName,
                photo = currentTrainer.Photo
            });
        }

        //秀出貼文
        public async Task<JsonResult> GetBlog()
        {
            // 取得當前登入的訓練師
            var currentTrainer = GetCurrentTrainer();

            var blogs = await _context.Blog
                                      .Include(b => b.Trainer)
                                      .Where(b => b.TrainerID == currentTrainer.TrainerID)
                                      .OrderByDescending(b => b.PostedDate)
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
                TrainerName = b.Trainer.TrainerName,
                TrainerPhoto = b.Trainer.Photo // 包括 Trainer.Photo

            }).ToList();

            // 返回 JSON 結果
            return Json(blogs);
        }

        //處理發文
        //[HttpPost]
        public async Task<IActionResult> CreatePost([FromForm] string title, [FromForm] string content, [FromForm] IFormFile? image1, [FromForm] IFormFile? image2)
        {
            var currentTrainer = GetCurrentTrainer();
            var blogPost = new Blog
            {
                TrainerID = currentTrainer.TrainerID,
                Title = title,
                Content = content,
                PostedDate = DateTime.Now
            };

            if (image1 != null)
            {
                var fileName = Path.GetFileName(image1.FileName);
                var filePath = Path.Combine("wwwroot/img", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image1.CopyToAsync(stream);
                }
                blogPost.Image1 = $"/img/{fileName}";
            }
            else
            {
                blogPost.Image1 = "";

            }

            if (image2 != null)
            {
                var fileName = Path.GetFileName(image2.FileName);
                var filePath = Path.Combine("wwwroot/img", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image2.CopyToAsync(stream);
                }
                blogPost.Image2 = $"/img/{fileName}";
            }
            else
            {
                blogPost.Image2 = "";

            }

            _context.Blog.Add(blogPost);
            await _context.SaveChangesAsync();

            return Ok(blogPost);
        }



        //貼文編輯
        //("EditPost/{id}")
        [HttpPost]
        public async Task<IActionResult> EditPost(int id, [FromForm] string title, [FromForm] string content, [FromForm] IFormFile? image1, [FromForm] IFormFile? image2, [FromForm] string deletedImages)
        {
            // 查找要編輯的貼文
            var blogPost = await _context.Blog.FindAsync(id);
            if (blogPost == null)
            {
                return NotFound(); // 如果貼文不存在，返回 404
            }

            // 更新貼文標題和內容
            blogPost.Title = title;
            blogPost.Content = content;

            // 解析被刪除圖片的列表
            var deletedImagesList = JsonConvert.DeserializeObject<List<string>>(deletedImages);

            // 如果圖片1在被刪除的列表中，刪除圖片並清空對應欄位
            if (deletedImagesList.Contains(blogPost.Image1))
            {
                var filePath = Path.Combine("wwwroot", blogPost.Image1.TrimStart('/'));
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath); // 刪除實際文件
                }
                blogPost.Image1 = null; // 清空數據庫中的圖片路徑
            }
            //else if (blogPost.Image1 == null)
            //{
            //    blogPost.Image1 = ""; // 清空圖片路徑
            //}

            // 如果圖片2在被刪除的列表中，刪除圖片並清空對應欄位
            if (deletedImagesList.Contains(blogPost.Image2))
            {
                var filePath = Path.Combine("wwwroot", blogPost.Image2.TrimStart('/'));
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath); // 刪除實際文件
                }
                blogPost.Image2 = null; // 清空數據庫中的圖片路徑
            }
            //else if (blogPost.Image2 == null)
            //{
            //    blogPost.Image2 = ""; // 清空圖片路徑
            //}

            // 如果有新圖片1，保存並更新圖片路徑
            if (image1 != null)
            {
                var fileName = Path.GetFileName(image1.FileName);
                var filePath = Path.Combine("wwwroot/img", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image1.CopyToAsync(stream); // 保存新圖片
                }
                blogPost.Image1 = $"/img/{fileName}"; // 更新數據庫中的圖片路徑
            }
            else if (blogPost.Image1 == null)
            {
                blogPost.Image1 = ""; // 清空圖片路徑
            }

            // 如果有新圖片2，保存並更新圖片路徑
            if (image2 != null)
            {
                var fileName = Path.GetFileName(image2.FileName);
                var filePath = Path.Combine("wwwroot/img", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image2.CopyToAsync(stream); // 保存新圖片
                }
                blogPost.Image2 = $"/img/{fileName}"; // 更新數據庫中的圖片路徑
            }
            else if (blogPost.Image2 == null)
            {
                blogPost.Image2 = ""; // 清空圖片路徑
            }

            // 保存對數據庫的更改
            await _context.SaveChangesAsync();

            return Ok(blogPost); // 返回編輯後的貼文信息
        }



        // 刪除貼文
        //[HttpDelete("DeletePost/{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var post = await _context.Blog.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            _context.Blog.Remove(post);
            await _context.SaveChangesAsync();

            return NoContent();
        }



        //課程預覽
        public async Task<JsonResult> GetCourses()
        {
            // 取得當前登入的訓練師
            var currentTrainer = GetCurrentTrainer();

            var courses = await _context.Course
                                        .Where(c => c.TrainerID == currentTrainer.TrainerID)

                                        .ToListAsync();


            var classSchedules = await _context.ClassSchedule
                                     .Where(cs => courses.Select(c => c.CourseID).Contains(cs.CourseID))
                                     .ToListAsync();

            var courseList = courses.Select(c => new
            {
                c.CourseID,
                c.CourseName,
                c.Description,
                c.ThumbnailUrl,
                c.CourseCategoryID,
                c.PetCategoryID,
                c.LocationID,
                c.CourseTypeID,
                c.Price,
                c.MaxParticipants,
                c.ApprovalStatus,
                IsPublished = classSchedules.Any(cs => cs.CourseID == c.CourseID) // 檢查課程是否已發佈
            }).ToList();

            // 返回 JSON 結果
            return Json(courseList);
        }

        // 取得下拉選單資料
        public JsonResult GetDropdownData()
        {
            var petCategories = _context.PetCategory.ToList();
            var courseCategories = _context.CourseCategory.ToList();
            var courseTypes = _context.CourseType.ToList();
            var locations = _context.Location.ToList();

            return Json(new
            {
                petCategories,
                courseCategories,
                courseTypes,
                locations
            });
        }


        // 新增課程
        [HttpPost]
        public async Task<IActionResult> CreateCourse([FromForm] Course course, [FromForm] IFormFile? thumbnailUrl)
        {
            var currentTrainer = GetCurrentTrainer();
            course.TrainerID = currentTrainer.TrainerID;
            course.CreatedAt = DateTime.Now;
            course.ApprovalStatus ="待審核";


            if (thumbnailUrl != null)
            {
                var fileName = Path.GetFileName(thumbnailUrl.FileName);
                var filePath = Path.Combine("wwwroot/img", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await thumbnailUrl.CopyToAsync(stream);
                }
                course.ThumbnailUrl = $"/img/{fileName}";
            }
            else {
                course.ThumbnailUrl = $"/img/coursethumbnail/noimage.jpg";

            }
            

            _context.Course.Add(course);
            await _context.SaveChangesAsync();

            return Ok(course);
        }



        // 編輯課程
        [HttpPost]
        public async Task<IActionResult> EditCourse(int id, [FromForm] Course course, [FromForm] IFormFile? thumbnailUrl)
        {
            var existingCourse = await _context.Course.FindAsync(id);
            if (existingCourse == null)
            {
                return NotFound();
            }

            existingCourse.CourseName = course.CourseName;
            existingCourse.Description = course.Description;
            existingCourse.PetCategoryID = course.PetCategoryID;
            existingCourse.CourseCategoryID = course.CourseCategoryID;
            existingCourse.CourseTypeID = course.CourseTypeID;
            existingCourse.LocationID = course.LocationID;
            existingCourse.Price = course.Price;
            existingCourse.MaxParticipants = course.MaxParticipants;

            if (thumbnailUrl != null)
            {
                var fileName = Path.GetFileName(thumbnailUrl.FileName);
                var filePath = Path.Combine("wwwroot/img", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await thumbnailUrl.CopyToAsync(stream);
                }
                existingCourse.ThumbnailUrl = $"/img/{fileName}";
            }

            _context.Course.Update(existingCourse);
            await _context.SaveChangesAsync();

            return Ok(existingCourse);
        }
        //刪除課程
        [HttpDelete]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            // 查找要刪除的課程
            var course = await _context.Course.FindAsync(id);
            if (course == null)
            {
                return NotFound(); // 如果課程不存在，返回404
            }

            // 從數據庫中移除課程
            _context.Course.Remove(course);
            await _context.SaveChangesAsync();

            return NoContent(); // 返回204狀態碼，表示成功刪除
        }


        // 發佈課程
        [HttpPost]
        public async Task<IActionResult> PublishCourse([FromBody] ClassSchedule schedule)
        {

            if (schedule == null || schedule.CourseID == 0 || schedule.Scheduler == DateTime.MinValue)
            {
                return BadRequest("Invalid data.");
            }

            // 獲取課程所屬的訓練師ID
            var course = await _context.Course.FindAsync(schedule.CourseID);
            if (course == null)
            {
                return BadRequest("此時段已經有排其課程了.");
            }

            var trainerId = course.TrainerID;

            var scheduleWithTimezone = new ClassSchedule
            {
                CourseID = schedule.CourseID,
                Scheduler = schedule.Scheduler.ToUniversalTime() // 保持 UTC 時間
            };

            _context.ClassSchedule.Add(scheduleWithTimezone);
            await _context.SaveChangesAsync();

            return Ok(new { message = "成功發佈課程" });
        }


        // 取特定课程的已發佈时间表
        public async Task<JsonResult> GetPublishedSchedules(int courseID)
        {
            var schedules = await _context.ClassSchedule
                                          .Where(cs => cs.CourseID == courseID)
                                          .ToListAsync();

            var scheduleList = schedules.Select(s => new
            {
                s.SchedulerID,
                s.CourseID,
                Scheduler = s.Scheduler.ToLocalTime() // 將 UTC 時間轉換回當地時間以顯示
            }).ToList();

            return Json(scheduleList);
        }



        // 收回發佈
        [HttpPost]
        public async Task<IActionResult> RetractPublish(int id)
        {
            var classSchedule = await _context.ClassSchedule.FirstOrDefaultAsync(cs => cs.SchedulerID == id);
            if (classSchedule == null)
            {
                return NotFound(new { message = "找不到該課程的發佈記錄" });
            }

            if (classSchedule.Scheduler <= DateTime.Now.AddDays(3))
            {
                return BadRequest(new { message = "此課程在3天內開課，無法收回發佈" });
            }

            _context.ClassSchedule.Remove(classSchedule);
            await _context.SaveChangesAsync();

            return Ok(new { message = "課程已收回發佈" });
        }


        //查看誰預約課程
        public async Task<IActionResult> GetReservations(int schedulerID)
        {
            var reservations = await (from od in _context.OrderDetail
                                      join o in _context.Order on od.OrderID equals o.OrderID
                                      join m in _context.Member on o.MemberID equals m.MemberID
                                      where od.SchedulerID == schedulerID && o.OrderStatus == "已付款"
                                      select new
                                      {
                                          m.MemberID,
                                          m.Name,
                                          m.Email,
                                          m.Phone,
                                          od.Quantity
                                      }).ToListAsync();

            return Ok(reservations);
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

        //導向哪位訓練師的部落格
        public async Task<IActionResult> TrainerBlog(int id)
        {
            var trainer = await _context.Trainer.FindAsync(id);
            if (trainer == null)
            {
                return NotFound();
            }

            var blogs = await _context.Blog
                .Where(b => b.TrainerID == id)
                .OrderByDescending(b => b.PostedDate)  // 根據發文時間排序，最新的在上面
                .ToListAsync();

            var courses = await (from c in _context.Course
                                 where c.TrainerID == id
                                 join pc in _context.PetCategory on c.PetCategoryID equals pc.PetCategoryID
                                 join ct in _context.CourseType on c.CourseTypeID equals ct.CourseTypeID
                                 join l in _context.Location on c.LocationID equals l.LocationID
                                 select new CourseViewModel
                                 {
                                     CourseID = c.CourseID,
                                     CourseName = c.CourseName,
                                     Description = c.Description,
                                     PetCategoryName = pc.PetCategoryName,
                                     CourseTypeName = ct.CourseTypeName,
                                     LocationName = l.LocationName,
                                     Price = c.Price,
                                     ThumbnailUrl = c.ThumbnailUrl,
                                     Scheduler = _context.ClassSchedule.Where(cs => cs.CourseID == c.CourseID).Select(cs => cs.Scheduler).ToList()
                                 }).ToListAsync();

            var viewModel = new TrainerBlogViewModel
            {
                Trainer = trainer,
                Blogs = blogs,
                Courses = courses
            };

            return View(viewModel);
        }


        // 取得課程詳細資料
        public async Task<JsonResult> GetCourseDetails(int id)
        {
            var course = await (from c in _context.Course
                                where c.CourseID == id
                                join pc in _context.PetCategory on c.PetCategoryID equals pc.PetCategoryID
                                join ct in _context.CourseType on c.CourseTypeID equals ct.CourseTypeID
                                join cc in _context.CourseCategory on c.CourseCategoryID equals cc.CourseCategoryID
                                join l in _context.Location on c.LocationID equals l.LocationID
                                select new CourseViewModel
                                {
                                    TrainerID= c.TrainerID,
                                    CourseID = c.CourseID,
                                    CourseName = c.CourseName,
                                    Description = c.Description,
                                    CourseCategoryName= cc.CourseCategoryName,
                                    PetCategoryName = pc.PetCategoryName,
                                    CourseTypeName = ct.CourseTypeName,
                                    LocationName = l.LocationName,
                                    Price = c.Price,
                                    MaxParticipants= c.MaxParticipants,
                                    ThumbnailUrl = c.ThumbnailUrl,
                                    Scheduler = _context.ClassSchedule.Where(cs => cs.CourseID == c.CourseID).Select(cs => cs.Scheduler).ToList()
                                }).FirstOrDefaultAsync();
            if (course == null)
            {
                return Json(null);
            }
            return Json(course);
        }



        //---------------------------------------------------------------------------------------------------

        //單一課程頁面
        public IActionResult singleCourse()
        {
            return View();
        }

        public async Task<JsonResult> getSingleCourse(int? id)
        {
            if (id == null)
            {
                return Json(new { error = "Invalid course ID" });
            }

            var singleCourseQuery = (from c in _context.Course.Where(c => c.CourseID == id)
                                     join loc in _context.Location on c.LocationID equals loc.LocationID
                                     join ct in _context.CourseType on c.CourseTypeID equals ct.CourseTypeID
                                     join pc in _context.PetCategory on c.PetCategoryID equals pc.PetCategoryID
                                     join cc in _context.CourseCategory on c.CourseCategoryID equals cc.CourseCategoryID
                                     select new CourseViewModel
                                     {
                                         CourseID = c.CourseID,
                                         CourseName = c.CourseName,
                                         TrainerID = c.TrainerID,
                                         PetCategoryName = pc.PetCategoryName,
                                         CourseCategoryName = cc.CourseCategoryName,
                                         CourseTypeName = ct.CourseTypeName,
                                         Description = c.Description,
                                         Price = c.Price,
                                         LocationName = loc.LocationName,
                                         MaxParticipants = c.MaxParticipants,
                                         CreatedAt = c.CreatedAt,
                                         ThumbnailUrl = c.ThumbnailUrl,
                                     });

            var singleCourse = await singleCourseQuery.FirstOrDefaultAsync();

            if (singleCourse == null)
            {
                return Json(new { error = "Course not found" });
            }

            return Json(singleCourse);
        }

        public async Task<JsonResult> getClassSchedule(int? id)
        {
            if (id == null)
            {
                return Json(new { message = "Course ID cannot be null" });
            }

            var classSchedules = await _context.ClassSchedule
                                               .Where(c => c.CourseID == id && c.Scheduler >= DateTime.UtcNow)
                                               .ToListAsync();

            for(int i = 0; i < classSchedules.Count; i++)
            {
                var enrollcount = await _context.OrderDetail.Where(od => od.CourseID == id && od.SchedulerID == classSchedules[i].SchedulerID).CountAsync();
                var maxparticipants = _context.Course.Where(c => c.CourseID == id).Select(c => c.MaxParticipants).FirstOrDefault();
                if(enrollcount >= maxparticipants)
                {
                    classSchedules.RemoveAt(i);
                }               
            }

            for(int i = 0; i < classSchedules.Count; i++)
            {
                var enrollcount = await _context.OrderDetail.Where(od => od.CourseID == id && od.SchedulerID == classSchedules[i].SchedulerID).CountAsync();
                var maxparticipants = _context.Course.Where(c => c.CourseID == id).Select(c => c.MaxParticipants).FirstOrDefault();
                classSchedules[i].EnrollmentCount = maxparticipants - enrollcount;
            }

            if (classSchedules == null || classSchedules.Count == 0)
            {
                return Json(new { message = "No schedules found for the given course ID" });
            }

            return Json(classSchedules);
        }

        //===================================================================================================
        //全部課程
        public async Task<JsonResult> getallCourses()
        {
            var CoursesQuery = (from c in _context.Course
                                join loc in _context.Location on c.LocationID equals loc.LocationID
                                join ct in _context.CourseType on c.CourseTypeID equals ct.CourseTypeID
                                join pc in _context.PetCategory on c.PetCategoryID equals pc.PetCategoryID
                                join cc in _context.CourseCategory on c.CourseCategoryID equals cc.CourseCategoryID
                                select new CourseViewModel
                                {
                                    CourseID = c.CourseID,
                                    CourseName = c.CourseName,
                                    TrainerID = c.TrainerID,
                                    PetCategoryName = pc.PetCategoryName,
                                    CourseCategoryName = cc.CourseCategoryName,
                                    CourseTypeName = ct.CourseTypeName,
                                    Description = c.Description,
                                    Price = c.Price,
                                    LocationName = loc.LocationName,
                                    MaxParticipants = c.MaxParticipants,
                                    CreatedAt = c.CreatedAt,
                                    ThumbnailUrl = c.ThumbnailUrl,
                                    ApprovalStatus = c.ApprovalStatus,
                                }).ToList();


            return Json(CoursesQuery);
        }

        //==================================================================================================================
        //審核功能
        public class UpdateApprovalStatusRequest
        {
            public int Id { get; set; }
            public string ApprovalStatus { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateApprovalStatus([FromBody] UpdateApprovalStatusRequest request)
        {
            var course = await _context.Course.FindAsync(request.Id);
            if (course == null)
            {
                return NotFound();
            }

            course.ApprovalStatus = request.ApprovalStatus;
            await _context.SaveChangesAsync();

            return Ok();
        }

        //===================================================================================================================
        //訓練師日歷

        public async Task<JsonResult> GetTrainerSchedule(int id)
        {
            try
            {

                var trainer = await _context.Trainer.Where(t => t.MemberID == id).FirstOrDefaultAsync();
                if (trainer == null)
                {
                    return Json(new { message = "Trainer not found" });
                }

                var trainerCourses = await _context.Course
                                                   .Where(c => c.TrainerID == trainer.TrainerID)
                                                   .ToListAsync();

                var trainerCourseIDs = trainerCourses.Select(tc => tc.CourseID).ToList();
                var allClassSchedules = new List<ClassScheduleViewModel>();

                foreach (var courseId in trainerCourseIDs)
                {
                    var classSchedules = await _context.ClassSchedule
                                                       .Where(cs => cs.CourseID == courseId && cs.Scheduler >= DateTime.UtcNow)
                                                       .ToListAsync();

                    foreach (var schedule in classSchedules)
                    {
                        var course = trainerCourses.FirstOrDefault(c => c.CourseID == courseId);
                        if (course != null)
                        {
                            var courseType = await _context.CourseType
                                                           .FirstOrDefaultAsync(ct => ct.CourseTypeID == course.CourseTypeID);

                            var courseCategory = await _context.CourseCategory
                                                               .FirstOrDefaultAsync(cc => cc.CourseCategoryID == course.CourseCategoryID);

                            allClassSchedules.Add(new ClassScheduleViewModel
                            {
                                SchedulerID = schedule.SchedulerID,
                                Scheduler = schedule.Scheduler,
                                CourseID = schedule.CourseID,
                                CourseName = course.CourseName,
                                CourseTypeName = courseType?.CourseTypeName,
                                CourseCategoryName = courseCategory?.CourseCategoryName,
                                EnrollmentCount = 0 // 先初始化为0，后面会更新
                            });
                        }
                    }
                }

                foreach (var schedule in allClassSchedules)
                {
                    var enrollCount = await _context.OrderDetail
                                                    .Where(od => od.CourseID == schedule.CourseID && od.SchedulerID == schedule.SchedulerID)
                                                    .CountAsync();

                    var maxParticipants = await _context.Course
                                                        .Where(c => c.CourseID == schedule.CourseID)
                                                        .Select(c => c.MaxParticipants)
                                                        .FirstOrDefaultAsync();

                    schedule.EnrollmentCount = maxParticipants - enrollCount;
                }

                if (allClassSchedules.Count == 0)
                {
                    return Json(new { message = "No schedules found for the given course ID" });
                }

                return Json(allClassSchedules);
            }
            catch (Exception ex)
            {
                // Log the exception (consider using a logging framework)
                Console.Error.WriteLine(ex);
                return Json(new { message = "An error occurred while processing your request", details = ex.Message });
            }
        }

    }
}


