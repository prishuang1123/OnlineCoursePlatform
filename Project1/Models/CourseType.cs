using Microsoft.AspNetCore.Identity;
using Project1.Models;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

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
