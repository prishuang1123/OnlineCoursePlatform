namespace Project1.DTO
{
    public class MemberDTO
    {
        public int MemberID { get; set; } // 會員編號，主鍵
        //public string? Photo { get; set; } //圖片:檔案
        public string? Name { get; set; } // 會員名稱
        public string? Email { get; set; } // 會員電子郵
        public string? Phone { get; set; } // 會員手機號
        //public bool IsTrainer { get; set; } // 是否為訓練師
    }
}
