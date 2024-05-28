using Project1.Models;

namespace Project1.ViewModels
{
    public class OrderDetailsVM
    {
        public Order order { get; set; }
        public IEnumerable<OrderDetail> orderDetails { get; set; }
    }
}
