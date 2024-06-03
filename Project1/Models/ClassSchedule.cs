using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Project1.Models
{
    public class ClassSchedule
    {
        [Key]
        public int SchedulerID { get; set; }//上課時間編號,主鍵
        
        public int CourseID { get; set; }//課程編號,外鍵

        public DateTime Scheduler { get; set; }//讓課日期&時段

        public int? EnrollmentCount { get; set; }// 報名人數

    }
}
