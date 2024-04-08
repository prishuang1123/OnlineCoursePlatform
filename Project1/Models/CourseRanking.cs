using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Project1.Models
{
	public class CourseRanking
	{
		[Key]
		public int CourseRankingID { get; set; } // 排行榜編號，主鍵，唯一識別每次排名

		public int CourseID { get; set; } // 課程編號，外鍵

		//[ForeignKey("CourseID")]
		//public Course Course { get; set; } // 課程導覽屬性

		public int TrainerID { get; set; } // 訓練師編號，外鍵

		//[ForeignKey("TrainerID")]
		//public Trainer Trainer { get; set; } // 訓練師導覽屬性

		public decimal CourseAverageRating { get; set; } // 平均評分

		public DateTime Date { get; set; } // 排名日期
	}
}
