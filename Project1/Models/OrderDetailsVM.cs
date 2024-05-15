namespace Project1.Models
{
	public class OrderDetailsVM
	{
        public Order order { get; set; }
        public IEnumerable<OrderDetail> orderDetails { get; set; }
    }
}
