namespace OrderDeliverySystem.AdministrationPanel.Services.Order.Models
{
    public class ChangeOrderItemStatusResult
    {
        public Guid OrderId { get; set; }
        public Guid OrderItemId { get; set; }
        public string NewStatus { get; set; }
    }
}
