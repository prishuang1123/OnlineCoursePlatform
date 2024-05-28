using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project1.Data
{
    //客製化類別
    //繼承IdentityUser
    public class ProjectUser : IdentityUser
    {
        
    }
    //記得修改ApplicationDbContext 加入客製化類別
}
