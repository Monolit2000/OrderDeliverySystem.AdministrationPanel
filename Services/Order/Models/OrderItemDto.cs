namespace OrderDeliverySystem.AdministrationPanel.Services.Order.Models
{
    public class OrderItemDto
    {
        public Guid ItemId { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public int Units { get; set; }

        public string PictureUrl { get; set; }
    }
}
