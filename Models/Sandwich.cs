namespace BreadpitProject.Models
{
    public class Sandwich
    {
        public int SandwichId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public double Price { get; set; }
        public string ImageUrl { get; set; } = null!;
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
