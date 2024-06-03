namespace Project1.ViewModels
{
    public class ClassScheduleViewModel
    {
        public int SchedulerID { get; set; }//上課時間編號,主鍵

        public int CourseID { get; set; }//課程編號,外鍵

        public DateTime Scheduler { get; set; }//讓課日期&時段

        public int? EnrollmentCount { get; set; }// 報名人數

        public string CourseName { get; set; } //課程名稱

        public string CourseCategoryName { get; set; } //運動 技能 陪玩

        public string CourseTypeName { get; set; }//團課 一對一
    }
}
