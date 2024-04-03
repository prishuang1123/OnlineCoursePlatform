using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Course
    {
 
            [Key]
            public int CourseID { get; set; }

            [Required]
            public string CourseName { get; set; }

            [ForeignKey("TrainerID")]
            public int TrainerID { get; set; }

            [Required]
            public string PetCategory { get; set; }

            [Required]
            public string CourseCategory { get; set; }

            public string CourseType { get; set; }

            public string Description { get; set; }

            [Required]
            public string ApprovalStatus { get; set; }

            public decimal Price { get; set; }
            
            [ForeignKey("DiscountID")]
            public int? DiscountID { get; set; }

            public string Location { get; set; }

            public int MaxParticipants { get; set; }

            public int EnrollmentCount { get; set; }

            public DateTime CreatedAt { get; set; }

            public DateTime UpdatedAt { get; set; }

            
    }
}
