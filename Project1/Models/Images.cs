using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Images
    {
        [Key]
        public int ImageID { get; set; }


        public int? TrianerID { get; set; }

        public int? CourseID { get; set; }

        public string? ImageUrl { get; set; }
    }
}
