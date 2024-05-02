using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Images
    {
        [Key]
        public int ImageID { get; set; }

        [Required]
        public int TrianerID { get; set; }

        public string? ImageUrl { get; set; }
    }
}
