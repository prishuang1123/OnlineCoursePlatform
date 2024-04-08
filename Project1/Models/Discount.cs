using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Discount
    {
        [Key]
        public int DiscountID { get; set; } // 折扣編號，主鍵
        [Required]
        public string DiscountName { get; set; } // 折扣名稱

        public string? DiscountDESC { get; set; } // 折扣說明
        [Required]
        public double DiscountPercentage { get; set; } // 折扣百分比
        [Required]
        public DateTime StartDate { get; set; } // 折扣開始日
        [Required]
        public DateTime EndDate { get; set; } // 折扣結束日
        [Required]
        public bool Active { get; set; } // 是否活耀: 1/0
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
