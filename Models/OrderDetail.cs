namespace BreadpitProject.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int SandwichId { get; set; }
        public int Quantity { get; set; }
        public double Subtotal { get; set; }
        public Order? Order { get; set; }
        public Sandwich? Sandwich { get; set; }
    }
}
