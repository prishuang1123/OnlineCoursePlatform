using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
	public class TrainerServiceArea
	{
		[Key]
		public int TeachingAreaID { get; set; } // 服務地區編號，主鍵

		public int LocationID { get; set; } // 地區編號，外鍵

		[ForeignKey("LocationID")]
		public Location Location { get; set; } // 地區

		public int TrainerID { get; set; } // 訓練師編號，外鍵
		
		[ForeignKey("TrainerID")]
		public Trainer Trainer { get; set; } // 訓練師
	}
}
