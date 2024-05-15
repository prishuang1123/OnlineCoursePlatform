namespace Project1.Models
{
    public class BrowseVM
    {
        public IEnumerable<Course> courseList { get; set; }
        public Trainer trainer { get; set; }
        public IEnumerable<CourseCategory> categoryList { get; set; }
    }
}
