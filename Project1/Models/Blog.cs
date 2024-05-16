using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }

        [Required]
        public int TrainerID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public string Content { get; set; }

        // 假設圖片以字串形式保存其路徑，你也可以自行修改成符合你的需求的型別
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        // 你可以繼續增加更多的圖片欄位，依此類推

        [Required]
        public DateTime PostedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public Trainer Trainer { get; set; } // 導航屬性
    }
}
