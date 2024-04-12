namespace Project1.DTO
{
    public class CourseRankDTO
    {
        public int CourseID { get; set; }

        public int TrainerID { get; set; }

        public decimal CourseAverageRating { get; set; }

        public DateTime Date { get; set; }

        public int? Clicks { get; set; }
    }
}
