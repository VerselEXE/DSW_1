namespace DSW_ProyFinal.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
    }
}
