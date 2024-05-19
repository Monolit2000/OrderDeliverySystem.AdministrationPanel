using Microsoft.AspNetCore.Components;
using OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models;
using OrderDeliverySystem.AdministrationPanel.Services.Order.Models;

namespace OrderDeliverySystem.AdministrationPanel.Components.Pages.Orders
{
    public class DisplayOrdersBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<OrderDto> Orders { get; set; }

    }

    public enum Status
    {
        Submitted,
        Paid,
        Shipped,
        Cancelled
    }
}
