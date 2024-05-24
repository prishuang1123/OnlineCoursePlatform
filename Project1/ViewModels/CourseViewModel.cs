namespace Project1.ViewModels
{
	public class CourseViewModel
	{
		public int CourseID { get; set; }
		public string CourseName { get; set; }

		public int TrainerID { get; set; }

		public string? PetCategoryName { get; set; }

		public string CourseCategoryName { get; set; }

		public string? CourseTypeName { get; set; }

		public string? Description { get; set; }

		public decimal Price { get; set; }

		public string LocationName { get; set; }

		public int? MaxParticipants { get; set; }

		public DateTime CreatedAt { get; set; }

		public string? ThumbnailUrl { get; set; }

		public List<DateTime> Scheduler { get; set; }
    }
}
