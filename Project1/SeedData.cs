//using Microsoft.AspNetCore.Identity;
//using Project1.Data;

//namespace Project1
//{
//    public class SeedData
//    {
//        //wayne:靜態方法:Initialize 初始化資料庫
//        public static async Task Initialize(IServiceProvider serviceProvider, UserManager<ProjectUser> userManager, RoleManager<ApplicationRole> roleManager)
//        {
//            //角色名稱 管理員 訓練師 會員

//            var roles = new List<ApplicationRole>
//            {
//                new ApplicationRole { Name = "Admin", DisplayName = "管理員", Description = "具有最高權限的管理員" },
//                new ApplicationRole { Name = "Member", DisplayName = "會員", Description = "普通會員" },
//                new ApplicationRole { Name = "Trainer", DisplayName = "訓練師", Description = "負責培訓的使用者" }
//            };
//            foreach (var role in roles)
//            {
//                var roleExist = await roleManager.RoleExistsAsync(role.Name);
//                if (!roleExist)
//                {
//                    await roleManager.CreateAsync(role); // 創建角色
//                }
//            }

//            //預設管理員名稱與帳號
//            var adminEmail = "admin@example.com";
//            var adminUser = new ProjectUser
//            {
//                UserName = "admin@admin.com",
//                Email = "admin@admin.com",
//                Name = "Admin" 
//            };

//            //string userPassword = "Admin@1234";
//            //var user = await userManager.FindByEmailAsync(adminEmail);

//            //如果管理員用戶不存在，則使用 UserManager 創建它，並設置初始密碼。成功創建後，將該用戶分配到 "Admin" 角色。
//            var user = await userManager.FindByEmailAsync(adminEmail);
//            if (user == null)
//            {
//                var createUser = await userManager.CreateAsync(adminUser, "Admin@1234");
//                if (createUser.Succeeded)
//                {
//                    await userManager.AddToRoleAsync(adminUser, "Admin");
//                }
//            }
//        }

//        internal static async Task Initialize(IServiceProvider services, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project1.Data
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider, UserManager<ProjectUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            // 確保角色存在
            var roles = new List<ApplicationRole>
            {
                new ApplicationRole { Name = "Admin", DisplayName = "管理員", Description = "具有最高權限的管理員" },
                new ApplicationRole { Name = "Member", DisplayName = "會員", Description = "普通會員" },
                new ApplicationRole { Name = "Trainer", DisplayName = "訓練師", Description = "負責培訓的使用者" }
            };

            foreach (var role in roles)
            {
                var roleExist = await roleManager.RoleExistsAsync(role.Name);
                if (!roleExist)
                {
                    await roleManager.CreateAsync(role);
                }
            }

            // 添加測試用管理員帳戶
            var adminEmail = "admin@example.com";
            var adminUser = new ProjectUser
            {
                UserName = adminEmail,
                Email = adminEmail,
                //Name = "Admin"
            };

            var user = await userManager.FindByEmailAsync(adminEmail);
            if (user == null)
            {
                var createUser = await userManager.CreateAsync(adminUser, "Admin@1234");
                if (createUser.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }
    }
}

