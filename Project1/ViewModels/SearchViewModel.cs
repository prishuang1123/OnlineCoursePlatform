using Project1.Models;

namespace Project1.ViewModels
{

    public class SearchViewModel
    {
        public List<Trainer> trainers { get; set; } = new List<Trainer>();
        public List<Course> courses { get; set; } = new List<Course>();
        public List<Specialization> specializations { get; set; } = new List<Specialization>();
        public List<PetCategory> petCategories { get; set; } = new List<PetCategory>();
        public List<CourseType> courseTypes { get; set; } = new List<CourseType>();
        public List<CourseCategory> courseCategories { get; set; } = new List<CourseCategory>();
    }
}
