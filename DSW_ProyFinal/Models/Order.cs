namespace DSW_ProyFinal.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
