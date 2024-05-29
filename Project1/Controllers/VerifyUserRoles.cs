using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Runtime.CompilerServices;

namespace Project1.Controllers
{
    //wayne:VerifyUserRoles 該控制器用來在專案執行時檢查用戶角色 (給需要的控制器來繼承)
    public class VerifyUserRoles : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public VerifyUserRoles(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    ViewBag.IsAdmin = await _userManager.IsInRoleAsync(user, "Admin");
                    ViewBag.IsTrainer = await _userManager.IsInRoleAsync(user, "Trainer");
                }
                else
                {
                    ViewBag.IsAdmin = false;
                    ViewBag.IsTrainer = false;
                }
            }
            else
            {
                ViewBag.IsAdmin = false;
                ViewBag.IsTrainer = false;
            }

            await next();
        }
    }
}
