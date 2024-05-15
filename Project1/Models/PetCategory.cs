using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class PetCategory
    {
        [Key]
        public int PetCategoryID { get; set; } //寵物類別編號

        [Display (Name= "寵物分類")]
        public string? PetCategoryName { get; set; } //寵物類別名稱
    }
}
