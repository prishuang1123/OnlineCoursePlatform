using System.ComponentModel.DataAnnotations.Schema;

namespace Project1.Models
{
    public class ClassSchedule
    {
        public int SchedulerID { get; set; }//上課時間編號,主鍵
        
        public int CourseID { get; set; }//課程編號,外鍵

        public DateTime Scheduler { get; set; }//讓課日期&時段
            
        //[ForeignKey("CourseID")]
        //public virtual Course Course { get; set; }
    }
}
