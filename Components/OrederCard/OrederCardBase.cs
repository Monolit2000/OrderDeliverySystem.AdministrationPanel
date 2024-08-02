using Microsoft.AspNetCore.Components;
using OrderDeliverySystem.AdministrationPanel.Services.Order.Models;
namespace OrderDeliverySystem.AdministrationPanel.Components.OrederCard
{
    public class OrederCardBase : ComponentBase
    {
        [Parameter]
        public OrderDto Order { get; set; }


    }
    public enum Status
    {
        Submitted,
        Paid,
        Shipped,
        Cancelled
    }
}
