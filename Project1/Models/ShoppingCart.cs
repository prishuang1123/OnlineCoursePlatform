using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class ShoppingCart
    {
        [Key]
        public int CartID { get; set; }//購物車主鍵

        //[ForeignKey("Course")]
        public int CourseID { get; set; }//外鍵

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }//課堂數量

        [Display(Name = "Created At")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }//創建時間

        [Display(Name = "Modified At")]
        [DataType(DataType.DateTime)]
        public DateTime? ModifiedAt { get; set; }//修改時間

        public int MemberID { get; set; }//會員ID
        // Navigation property
        //public virtual Course Course { get; set; }
		
        public int SchedulerID { get; set; } //上課時間編號

        public ShoppingCart()
        {
            this.CreatedAt = DateTime.UtcNow;
        }

	}
}
