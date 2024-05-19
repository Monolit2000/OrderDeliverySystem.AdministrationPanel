namespace OrderDeliverySystem.AdministrationPanel.Services.Order.Models
{
    public class ChangeOrderStatusRequest
    {
        public Guid OrderId { get; set; }
        public string Status { get; set; }
    }
}
