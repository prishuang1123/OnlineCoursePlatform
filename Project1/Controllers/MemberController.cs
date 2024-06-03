using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;

namespace Project1.Controllers
{
    //Wayne:會員註冊後重新導向填寫會員資料
    public class MemberController : VerifyUserRoles
    {
        private readonly ProjectDbContext _context;
        private readonly UserManager<ProjectUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IWebHostEnvironment _environment;

        public MemberController(UserManager<ProjectUser> userManager, SignInManager<ProjectUser> signInManager, RoleManager<ApplicationRole> roleManager, ProjectDbContext context, IWebHostEnvironment environment) : base(userManager, signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
            _environment = environment;
        }

        // GET: Member
        public async Task<IActionResult> Index()
        {
            return View(await _context.Member.ToListAsync());
        }

        // GET: Member/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Member
                .FirstOrDefaultAsync(m => m.MemberID == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // GET: Member/Create
        public async Task<IActionResult> Create()
        {
            //wayne:取得用戶當前ID
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }

            var model = new Member
            {
                AspID = user.Id,
                Email = user.Email,
                IsTrainer = false
            };
            return View(model);
        }

        // POST: Member/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MemberID,Name,Email,Phone,Birthday,RegistrationDate,ResidenceArea,IsTrainer,Photo,Address,AspID")] Member member,IFormFile photo)
        {
            
            if (ModelState.IsValid)
            {
                //wayne:確保AspID不會被覆蓋
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return NotFound();
                }
                member.AspID = user.Id;


                //保存圖片
                if (photo != null && photo.Length > 0)
                {
                    // 生成唯一的檔名
                    var fileName = Path.GetFileNameWithoutExtension(photo.FileName);
                    var extension = Path.GetExtension(photo.FileName);
                    var uniqueFileName = $"{fileName}_{Guid.NewGuid()}{extension}";

                    // 指定保存路徑
                    var uploadPath = Path.Combine(_environment.WebRootPath, "img", "MembersPhoto");
                    var filePath = Path.Combine(uploadPath, uniqueFileName);

                    // 確保目錄存在
                    if (!Directory.Exists(uploadPath))
                    {
                        Directory.CreateDirectory(uploadPath);
                    }

                    // 保存檔案
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await photo.CopyToAsync(stream);
                    }

                    // 將圖片路徑保存到資料庫
                    member.Photo = Path.Combine("img", "MembersPhoto", uniqueFileName).Replace("\\", "/");
                }

                _context.Add(member);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                //TempData["SuccessMessage"] = "會員加入成功";
                return RedirectToAction("Index", "Home");
            }
            return View(member);
        }

        


        // GET: Member/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //wayne:抓到MemberID
            var userId = _userManager.GetUserId(User);
            var member = await _context.Member.FirstOrDefaultAsync(m => m.AspID == userId);
            //var MemID = Mem.MemberID;
            //ViewBag.MemID = MemID;
            if (userId == null)
            {
                return NotFound();
            }
            var photoPath = member.Photo;
            ViewData["PhotoPath"] = photoPath;
            return View(member);
        }

        // POST: Member/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MemberID,Name,Email,Phone,Birthday,RegistrationDate,ResidenceArea,IsTrainer,Photo,Address,AspID")] Member member,IFormFile photo)
        {
            var userId = _userManager.GetUserId(User);
            var existingMember = await _context.Member.FirstOrDefaultAsync(m => m.AspID == userId);
            if (existingMember == null)
            {
                return NotFound();
            }

           

            if (ModelState.IsValid)
            {
                try
                {
                    //處理圖片上傳
                    if (photo != null && photo.Length > 0)
                    {
                        // 生成唯一的檔名
                        var fileName = Path.GetFileNameWithoutExtension(photo.FileName);
                        var extension = Path.GetExtension(photo.FileName);
                        var uniqueFileName = $"{fileName}_{Guid.NewGuid()}{extension}";

                        // 指定保存路徑
                        var uploadPath = Path.Combine(_environment.WebRootPath, "img/MembersPhoto");
                        var filePath = Path.Combine(uploadPath, uniqueFileName);

                        // 確保目錄存在
                        if (!Directory.Exists(uploadPath))
                        {
                            Directory.CreateDirectory(uploadPath);
                        }

                        // 保存檔案
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await photo.CopyToAsync(stream);
                        }

                        // 刪除舊圖片
                        if (!string.IsNullOrEmpty(existingMember.Photo))
                        {
                            var oldFilePath = Path.Combine(_environment.WebRootPath, existingMember.Photo);
                            if (System.IO.File.Exists(oldFilePath))
                            {
                                System.IO.File.Delete(oldFilePath);
                            }
                        }

                        // 將新圖片路徑保存到資料庫
                        existingMember.Photo = Path.Combine("img/MembersPhoto", uniqueFileName);
                    }

                    _context.Update(existingMember);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "資料更新成功";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberExists(existingMember.MemberID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Edit));
            }
            return View(member);
        }

        // GET: Member/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Member
                .FirstOrDefaultAsync(m => m.MemberID == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // POST: Member/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var member = await _context.Member.FindAsync(id);
            if (member != null)
            {
                _context.Member.Remove(member);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //[HttpPost]
        //public async Task<IActionResult> EditProfile(Member member, string Photo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var userId = _userManager.GetUserId(User); // 抓當前登入的ID
        //        var existingMember = await _context.Member.FirstOrDefaultAsync(m => m.AspID == userId);
        //        if (existingMember == null)
        //        {
        //            return NotFound();
        //        }

        //        if (!string.IsNullOrEmpty(Photo))
        //        {
        //            existingMember.Photo = Photo;
        //        }


        //        _context.Update(existingMember);
        //        await _context.SaveChangesAsync();

        //        return RedirectToAction(nameof(Edit));
        //    }

        //    return View(member);
        //}

        //[HttpPost]
        //public async Task<IActionResult> UploadPhoto(IFormFile file)
        //{
        //    if (file != null && file.Length > 0)
        //    {
        //        var fileExtension = Path.GetExtension(file.FileName);
        //        var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };

        //        if (!allowedExtensions.Contains(fileExtension.ToLower()))
        //        {
        //            return BadRequest("無效的檔案格式。僅支援 .jpg, .jpeg, .png, .gif 格式。");
        //        }

        //        var fileName = Guid.NewGuid().ToString() + fileExtension;
        //        var filePath = Path.Combine("wwwroot/uploads", fileName);

        //        using (var stream = new FileStream(filePath, FileMode.Create))
        //        {
        //            await file.CopyToAsync(stream);
        //        }

        //        return Ok(new { filePath = "/uploads/" + fileName });
        //    }

        //    return BadRequest("上傳失敗");
        //}




        private bool MemberExists(int id)
        {
            return _context.Member.Any(e => e.MemberID == id);
        }
    }
}
