using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
	public class PTDetail
	{
		public int PTDetaillID { get; set; } // PT課程明細編號，主鍵

		public int MemberID { get; set; } // 會員ID，外鍵
		
		//[ForeignKey("MemberID")]
		//public Member Member { get; set; } // 定義會員的導覽屬性

		public int CourseID { get; set; } // 課程編號，外鍵

		//[ForeignKey("CourseID")]
		//public Course Course { get; set; } // 定義課程的導覽屬性

		public int Quantity { get; set; } // 剩餘課堂數量
	}
}
