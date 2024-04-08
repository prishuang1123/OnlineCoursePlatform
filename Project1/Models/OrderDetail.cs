using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }//訂單明細編號,主鍵

        //[ForeignKey("Order")]
        public int OrderID { get; set; }//訂單編號,外鍵

        //[ForeignKey("Course")]
        public int CourseID { get; set; }//課程編號,外鍵

        //[ForeignKey("Payment")]
        public int PaymentID { get; set; }//外鍵

        public int Quantity { get; set; }//課程數量

        //[ForeignKey("Discount")]
        public int DiscountID { get; set; }//折扣編號,外鍵

        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }//課程單價

        public decimal Subtotal { get; set; }//小計

        [Display(Name = "Created At")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }//新增時間

        [Display(Name = "Modified At")]
        [DataType(DataType.DateTime)]
        public DateTime ModifiedAt { get; set; }//修改時間

        //Navigation properties
        //public virtual Order Order { get; set; }
        //public virtual Course Course { get; set; }
        //public virtual Payment Payment { get; set; }
        //public virtual Discount Discount { get; set; }
    }
}
