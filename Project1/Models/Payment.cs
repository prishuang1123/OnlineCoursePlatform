using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; } // 主鍵

        
        public int OrderID { get; set; } // 外鍵

        [ForeignKey("OrderID")]
        public Order Order { get; set; }

        [Required]
        public string PaymentMethod { get; set; } // 支付方式
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
