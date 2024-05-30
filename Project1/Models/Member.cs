using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
	public class Member
	{
		[Key]
		public int MemberID { get; set; } // 會員編號，主鍵

		[Required(ErrorMessage = "姓名為必填欄位")]
		[Display(Name ="姓名")]
		public string Name { get; set; } // 會員名稱

		[Required(ErrorMessage = "電子郵件為必填欄位")]
		[Display(Name="電子郵件")]
		[EmailAddress(ErrorMessage ="電子郵件格式錯誤")]
		public string Email { get; set; } // 會員電子郵件，設為帳號

		[Required(ErrorMessage ="手機號碼為必填欄位")]
		[Display(Name="手機號碼")]
		public string Phone { get; set; } // 會員手機號碼

		[Required(ErrorMessage = "生日為必填欄位")]
		[Display(Name="生日")]
		public DateTime? Birthday { get; set; } // 會員生日

		[Required(ErrorMessage = "註冊日期")]
		[Display(Name="註冊日期")]
		public DateTime? RegistrationDate { get; set; } // 會員註冊日期

		[Required(ErrorMessage ="居住區為必填欄位")]
		[Display(Name = "居住地區")]
		public string? ResidenceArea { get; set; } // 會員居住區域

		public bool? IsTrainer { get; set; } // 是否為訓練師，1/0

		[Display(Name="大頭貼")]
		public string? Photo { get; set; }

		[Display(Name ="居住地址")]
		public string Address { get; set; }

		public string? AspID { get; set; }

		public bool IsProfileCompleted { get; set; } //會員資料是否已填寫完成
    }
}
