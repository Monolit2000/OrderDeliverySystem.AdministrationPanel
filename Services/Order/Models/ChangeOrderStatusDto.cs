namespace OrderDeliverySystem.AdministrationPanel.Services.Order.Models
{
    public class ChangeOrderStatusResult
    {
        public Guid OrderId { get; set; }

        public string OrderStatus { get; set; }
    }
}
