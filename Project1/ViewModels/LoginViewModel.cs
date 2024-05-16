using System.ComponentModel.DataAnnotations;

namespace Project1.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="姓名為必填欄位")]
        [Display(Name="姓名")]
        [StringLength(maximumLength:20,MinimumLength =3,ErrorMessage ="姓名長度不正確")]
        public string Name { get; set; }
        [Required(ErrorMessage = "電子郵件為必填欄位")]
        [EmailAddress(ErrorMessage ="電子郵件格式錯誤")]
        [Display(Name = "電子郵件")]
        public string Email { get; set; }
        [Display(Name = "手機號碼")]

        public string? Phone { get; set; }
    }
}