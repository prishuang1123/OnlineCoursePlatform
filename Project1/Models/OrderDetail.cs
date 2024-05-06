using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }//訂單明細編號,主鍵

        //[ForeignKey("Order")]
        public int OrderID { get; set; }//訂單編號,外鍵

        //[ForeignKey("Course")]
        public int CourseID { get; set; }//課程編號,外鍵

        [Range(1,10)]
        public int Quantity { get; set; }//課程數量
        //, (ErrorMessage ="Quantity can only be between 1-10")

        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }//課程單價


        [Display(Name = "Created At")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }//新增時間

        [Display(Name = "Modified At")]
        [DataType(DataType.DateTime)]
        public DateTime? ModifiedAt { get; set; }//修改時間

		public static implicit operator OrderDetail(List<OrderDetail> v)
		{
			throw new NotImplementedException();
		}

        public OrderDetail()
        {
            this.CreatedAt = DateTime.UtcNow;
        }

        //Navigation properties
        //public virtual Order Order { get; set; }
        //public virtual Course Course { get; set; }
        //public virtual Payment Payment { get; set; }
        //public virtual Discount Discount { get; set; }
    }
}
