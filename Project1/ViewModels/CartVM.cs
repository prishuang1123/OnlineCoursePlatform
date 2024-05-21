using Project1.Models;

namespace Project1.ViewModels
{
	public class CartVM
	{
		//public IEnumerable<Course> courseList { get; set; }
		public IEnumerable<Course> courseList { get; set; }
		public IEnumerable<ShoppingCart> shoppingCartList { get; set; }
		public IEnumerable<ClassSchedule> classScheduleList { get; set; }
		public int memberId { get; set; }
		public decimal subtotal { get; set; }
		public double discountPercentage { get; set; }
	}
}
