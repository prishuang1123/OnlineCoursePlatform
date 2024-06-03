using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Project1.Data
{
    //IdentityDbContext<加入繼承至IdentityUser的客製化類別>
    //在IdentityDbContext的泛型參數中指定string是因為IdentityDbContext需要知道用作主鍵（Primary Key）的類型。在大多數情況下，ASP.NET Identity使用string作為用戶和角色的主鍵類型。如果您使用自定義主鍵類型（例如int或Guid），則需要在這裡指定該類型。
    public class ApplicationDbContext : IdentityDbContext<ProjectUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        
    }
}
