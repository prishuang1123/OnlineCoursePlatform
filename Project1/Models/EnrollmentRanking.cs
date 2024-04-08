using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class EnrollmentRanking
    {
        public int EnrollmentRankingID { get; set; }//唯一識別每次排名,主鍵

        public int CourseID { get; set; }//外鍵

        public int? TrainerID { get; set; }//外鍵

        [Display(Name = "Enrollment Count")]
        public int EnrollmentCount { get; set; }//報名人數

        public int Rank { get; set; }//排名

        [Display(Name = "Ranking Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }//排名日期

        // Navigation properties
        //[ForeignKey("CourseID")]
        //public virtual Course Course { get; set; }
        //[ForeignKey("TrainerID")]
        //public virtual Trainer Trainer { get; set; }
    }
}
