using OrderDeliverySystem.AdministrationPanel.Components.Pages.Orders;
using System.Text.Json.Serialization;

namespace OrderDeliverySystem.AdministrationPanel.Services.Order.Models
{
    public class OrderDto
    {
        public Guid OrderId { get; set; }

        public Guid BuyerId { get; set; }

        public string Status { get; set; }

        public DateTime Created { get; set; }

        public string Description { get; set; }

        public List<OrderItemDto> OrderItems { get; set; } = [];

        [JsonIgnore]
        public Status StatusEnum { get; set; }  
    }
}
