using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project1.Data;
using Project1.Models;
using Project1.ViewModels;

namespace Project1.Controllers
{
    //wayne:該控制器給予Admin權限管制 繼承VerifyUserRoles
    //wayne:控制器RoleManagement使管理員具有給予用戶權限的功能
    [Authorize(Roles = "Admin")]
    public class RoleManagementController : VerifyUserRoles
    {
        private readonly UserManager<ProjectUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly ProjectDbContext _context;

        public RoleManagementController(UserManager<ProjectUser> userManager,SignInManager<ProjectUser> signInManager, RoleManager<ApplicationRole> roleManager, ProjectDbContext context) : base(userManager, signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var users = _userManager.Users.ToList();
            var model = new List<UserRolesViewModel>();

            foreach (var user in users)
            {
                var userRolesViewModel = new UserRolesViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    Roles = await _userManager.GetRolesAsync(user)
                };
                model.Add(userRolesViewModel);
            }

            return View(model);
        }

        //GET RoleManagement/Manage
        public async Task<IActionResult> Manage(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            var model = new ManageUserRolesViewModel
            {
                UserId = user.Id,
                UserName = user.UserName,
                Roles = _roleManager.Roles.Select(r => new RoleViewModel
                {
                    RoleId = r.Id,
                    RoleName = r.Name,
                    Selected = _userManager.IsInRoleAsync(user, r.Name).Result
                }).ToList()
            };

            return View(model);
        }

        //Post RoleManagement/Manage
        [HttpPost]
        public async Task<IActionResult> Manage(ManageUserRolesViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null)
            {
                return NotFound();
            }

            var userRoles = await _userManager.GetRolesAsync(user);
            var selectedRoles = model.Roles.Where(x => x.Selected).Select(y => y.RoleName);

            var result = await _userManager.AddToRolesAsync(user, selectedRoles.Except(userRoles));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Failed to add roles");
                return View(model);
            }

            result = await _userManager.RemoveFromRolesAsync(user, userRoles.Except(selectedRoles));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Failed to remove roles");
                return View(model);
            }

            // 更新IsTrainer欄位
            var member = _context.Member.FirstOrDefault(m => m.AspID == user.Id);
            if (member != null)
            {
                if (selectedRoles.Contains("Trainer"))
                {
                    member.IsTrainer = true;
                }
                else
                {
                    member.IsTrainer = false;
                }

                _context.Update(member);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}
