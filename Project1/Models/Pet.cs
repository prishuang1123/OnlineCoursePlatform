using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
	public class Pet
	{
		[Key]
		public int PetID { get; set; } // 寵物編號，主鍵

		[Required]
		public string PetName { get; set; } // 寵物名字

		[Required]
		public string PetType { get; set; } // 寵物種類（例如：貓、狗等）

		[Required]
		public string Gender { get; set; } // 寵物的性別

		public double Weight { get; set; } // 寵物的體重

		public string Breed { get; set; } // 寵物的品種

		public int MemberID { get; set; } // 主人的ID

		//[ForeignKey("MemberID")]
		//public Member Member { get; set; } // 定義導覽屬性

		public DateTime Birthday { get; set; } // 寵物的生日
	}
}
