namespace Project1.ViewModels
{
    public class CourseRatingViewModel
    {
        public int CourseRatingID { get; set; } // 評分編號，主鍵，唯一識別每次評分

        public int CourseID { get; set; } // 課程編號，外鍵

        public int TrainerID { get; set; } // 訓練師編號，外鍵

        public string UserName { get; set; } // 用戶編號，外鍵

        public int Rating { get; set; } // 評分，例如1至5

        public string Comment { get; set; } // 評論

        public DateTime RatingDate { get; set; } // 評分日期
    }
}
