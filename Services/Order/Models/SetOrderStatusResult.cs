namespace OrderDeliverySystem.AdministrationPanel.Services.Order.Models
{
    public class SetOrderStatusResult
    {
        public Guid OrderId { get; set; }

        public string OrderStatus { get; set; }
    }
}
