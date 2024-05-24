using Microsoft.AspNetCore.Identity;

namespace Project1
{
    public class SeedData
    {
        //wayne:靜態方法:Initialize 初始化資料庫
        public static async Task Initialize(IServiceProvider serviceProvider, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //角色名稱 管理員 訓練師 會員
            string[] roleNames = { "Admin", "Trainer", "Member" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(roleName)); // 創建角色
                }
            }

            //預設管理員名稱與帳號
            var adminUser = new IdentityUser
            {
                UserName = "admin@admin.com",
                Email = "admin@admin.com"
            };

            string userPassword = "Admin@1234";
            var user = await userManager.FindByEmailAsync("admin@admin.com");

            //如果管理員用戶不存在，則使用 UserManager 創建它，並設置初始密碼。成功創建後，將該用戶分配到 "Admin" 角色。
            if (user == null)
            {
                var createAdminUser = await userManager.CreateAsync(adminUser, userPassword);
                if (createAdminUser.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin"); // 將用戶分配給角色
                }
            }
        }
    }
}
