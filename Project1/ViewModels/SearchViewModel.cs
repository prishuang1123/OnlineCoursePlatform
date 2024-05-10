using Project1.Models;

namespace Project1.ViewModels
{
    


    public class SearchViewModel
    {
        public List<Trainer> trainers { get; set; } = new List<Trainer>();
        public List<Course> courses { get; set; } = new List<Course>();
    }
}
