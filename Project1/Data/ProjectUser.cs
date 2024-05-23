using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Project1.Data
{
    //客製化類別
    //繼承IdentityUser
    public class ProjectUser : IdentityUser
    {
        //客製化資料欄位 記得要有索引
    }
    //記得修改ApplicationDbContext 加入客製化類別
}
