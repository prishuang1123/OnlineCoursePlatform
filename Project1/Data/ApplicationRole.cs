using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

//Wayne:客製化AspNetRole資料表
public class ApplicationRole : IdentityRole
{
    [MaxLength(100)]
    [Display(Name = "顯示名稱")]
    public string DisplayName { get; set; }

    [MaxLength(100)]
    [Display(Name = "描述")]
    public string Description { get; set; }
}
