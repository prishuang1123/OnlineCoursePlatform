using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Trainer
    {
		[Key]
        [Display(Name = "訓練師ID")]
        public int TrainerID { get; set; } // 訓練師編號，主鍵

        [Display(Name = "會員ID")]
        public int MemberID { get; set; } // 會員ID，外鍵

        [Display(Name = "訓練師姓名")]
        public string TrainerName { get; set; } // 名字

        [Display(Name = "專長")]
        public string Specialization { get; set; } // 專長

        [Display(Name = "經歷")]
        public string Experience { get; set; } // 經歷

        [Display(Name = "資格")]
        public string Qualifications { get; set; } // 資格

        [Display(Name = "審核狀態")]
        public string Status { get; set; } // 審核狀態，例如 "尚未審核"、"已審核"、"審核未通過"

        [Display(Name = "大頭貼")]
        public string? Photo {  get; set; } //圖片

    }
}
