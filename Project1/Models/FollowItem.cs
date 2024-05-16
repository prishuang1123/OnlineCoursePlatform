using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
	public class FollowItem
	{
		[Key]
		public int FollowItemId { get; set; }//購物車主鍵

		//[ForeignKey("Course")]
		public int CourseID { get; set; }//外鍵

		public int MemberID { get; set; }//會員ID
										  // Navigation property
										  //public virtual Course Course { get; set; }
	}
}
