using ContactManager.Models;

namespace BreadpitProject.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public Contact? Contact { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }

    }
}
