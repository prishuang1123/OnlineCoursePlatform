using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Trainer
    {
		[Key]
		public int TrainerID { get; set; } // 訓練師編號，主鍵

		public int MemberID { get; set; } // 會員ID，外鍵

		[ForeignKey("MemberID")]
		public Member Member { get; set; } // 會員

		public string TrainerName { get; set; } // 名字

		public string Specialization { get; set; } // 專長

		public string Experience { get; set; } // 經歷

		public string Qualifications { get; set; } // 資格

		public string Status { get; set; } // 審核狀態，例如 "尚未審核"、"已審核"、"審核未通過"
	}
}
