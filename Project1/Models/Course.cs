using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Course
    {

		[Key]
		public int CourseID { get; set; } // 課程編號，主鍵

		[Required]
		[Display(Name ="課程名稱")]
		public string CourseName { get; set; } // 課程名稱

        [Display(Name = "訓練師ID")]
        public int TrainerID { get; set; } // 訓練師編號，外鍵

		//[ForeignKey("TrainerID")]
		//public Trainer Trainer { get; set; } // 訓練師

		[Required]
        [Display(Name = "寵物分類")]
        public string PetCategory { get; set; } // 寵物分類

		[Required]
        [Display(Name = "課程分類")]
        public int CourseCategoryID { get; set; } // 課程分類

        [Display(Name = "課程類型")]
        public string? CourseType { get; set; } // 課程類型

        [Display(Name = "課程描述")]
        public string? Description { get; set; } // 課程描述

        [Display(Name = "審核狀態")]
        public string? ApprovalStatus { get; set; } // 審核狀態

        [Display(Name = "價格")]
        public decimal Price { get; set; } // 價格

        [Display(Name = "上課地點")]
        public int? LocationID { get; set; } // 上課地址

        [Display(Name = "人數上限")]
        public int? MaxParticipants { get; set; } // 課程參加人數上限

        [Display(Name = "已報名人數")]
        public int? EnrollmentCount { get; set; } // 報名人數

        [Display(Name = "課程建立時間")]
        public DateTime CreatedAt { get; set; } // 課程建立時間

        [Display(Name = "課程編輯時間")]
        public DateTime UpdatedAt { get; set; } // 課程最後更新時間

        [Display(Name = "點擊")]
        public int? Clicks { get; set; } // 課程頁面被點擊次數

        [Display (Name = "封面圖")]
        public string? ThumbnailUrl { get; set; }

    

    }
}
