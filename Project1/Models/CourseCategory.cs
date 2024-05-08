using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class CourseCategory
    {
        [Key]
        public int CourseCategoryID { get; set; }

        [Display(Name = "課程類別")]
        public string CourseCategoryName { get; set; }
    }
}
