using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Project1.Models
{
    public class Order
    {
        [Key]
        [DisplayName("OrderID")]
        public int OrderID { get; set; } // 訂單編號，主鍵

        [Required]
        [DisplayName("MemberID")]
        public int MemberID { get; set; } // 會員編號，外鍵

        //[ForeignKey("MemberID")]
        //public Member Member { get; set; }


        [Required]
        [DisplayName("Order Date")]
        public DateTime OrderDate { get; set; } // 訂單日期
        [Required]
        [DisplayName("Order Status")]
        public string OrderStatus { get; set; } // 訂單狀態
        [Required]
        [DisplayName("Total Amount")]
        public decimal TotalAmount { get; set; } // 訂單總額
        [Required]
        [DisplayName("Created At")]
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        //public ICollection<Payment> Payment { get; set; }

        public Order()
        {
            this.CreatedAt = DateTime.UtcNow;
		}
    }
}
