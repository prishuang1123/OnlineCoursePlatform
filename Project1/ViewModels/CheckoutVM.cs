using Project1.Models;

namespace Project1.ViewModels
{
    public class CheckoutVM
    {
        public Member Member {  get; set; }
        public Discount Discount { get; set; }
        public Order Order { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public Payment Payment { get; set; }
        public IEnumerable<Location> Location { get; set; }
        public IEnumerable<ShoppingCart> cartItemList { get; set; }

    }
}
