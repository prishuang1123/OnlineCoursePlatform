using Project1.Models;
using System.ComponentModel.DataAnnotations;

namespace Project1.ViewModel
{
    public class CourseRankViewModel
    {
        public int CourseID { get; set; }
        public int TrainerID { get; set; }
        public int? Clicks { get; set; }

        public decimal CourseAverageRating { get; set; }

        public int TotalQuantity { get; set; }

    }
}
