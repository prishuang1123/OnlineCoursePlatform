namespace Project1.Models
{
	public class OrderDetailsViewModel
	{
        public Order order { get; set; }
        public IEnumerable<OrderDetail> orderDetails { get; set; }
    }
}
