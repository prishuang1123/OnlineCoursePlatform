using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Course
    {

		[Key]
		public int CourseID { get; set; } // 課程編號，主鍵

		[Required]
		public string CourseName { get; set; } // 課程名稱

		public int TrainerID { get; set; } // 訓練師編號，外鍵

		//[ForeignKey("TrainerID")]
		//public Trainer Trainer { get; set; } // 訓練師

		[Required]
		public string PetCategory { get; set; } // 寵物分類

		[Required]
		public string CourseCategory { get; set; } // 課程分類

		public string CourseType { get; set; } // 課程類型

		public string Description { get; set; } // 課程描述

		
		public string? ApprovalStatus { get; set; } // 審核狀態

		public decimal Price { get; set; } // 價格

		public int? DiscountID { get; set; } // 折扣編號，外鍵

		//[ForeignKey("DiscountID")]
		//public Discount Discount { get; set; } // 折扣

		public string Location { get; set; } // 上課地址

		public int MaxParticipants { get; set; } // 課程參加人數上限

		public int? EnrollmentCount { get; set; } // 報名人數

		public DateTime CreatedAt { get; set; } // 課程建立時間

		public DateTime UpdatedAt { get; set; } // 課程最後更新時間

		public int? Clicks { get; set; } // 課程頁面被點擊次數
	}
}
