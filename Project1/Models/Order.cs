using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; } // 訂單編號，主鍵

        
        public int MemberID { get; set; } // 會員編號，外鍵

        //[ForeignKey("MemberID")]
        //public Member Member { get; set; }


        [Required]
        public DateTime OrderDate { get; set; } // 訂單日期
        [Required]
        public string OrderStatus { get; set; } // 訂單狀態
        [Required]
        public decimal TotalAmount { get; set; } // 訂單總額
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public ICollection<Payment> Payment { get; set; }
    }
}
