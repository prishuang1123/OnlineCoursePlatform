using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Specialization
    {
        [Key]
        public int SpecializationID { get; set; } // 專長ID

        [Display (Name = "專長")]
        public string SpecializationName { get; set; } // 專長名稱
    }
}
