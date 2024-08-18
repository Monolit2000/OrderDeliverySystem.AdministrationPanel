namespace OrderDeliverySystem.AdministrationPanel.Services.Order.Models
{
    public class OrderItemDtoByDay
    {
        public Guid OrderId { get; set; }
        public Guid BuyerId { get; set; }
        public string PhoneNumber { get; set; } 
        public Guid OrderItemId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Units { get; set; }
        public string Status { get; set; } = "Waiting";
        public DateTime Deadline { get; set; }
        public string? OptionItemName { get; set; }
    }
}
