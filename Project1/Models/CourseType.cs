using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class CourseType
    {
        [Key]
        public int CourseTypeID { get; set; }

        [Display (Name = "課程類型")]
        public string CourseTypeName { get; set; }
    }
}
