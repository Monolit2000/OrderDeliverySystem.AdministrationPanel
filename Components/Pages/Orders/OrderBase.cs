using Microsoft.AspNetCore.Components;
using OrderDeliverySystem.AdministrationPanel.Services.Contracts;
using OrderDeliverySystem.AdministrationPanel.Services.Order.Models;

namespace OrderDeliverySystem.AdministrationPanel.Components.Pages.Orders
{
    public class OrderBase : ComponentBase
    {
        [Inject]
        public IOrderService OrderService { get; set; }

        public IEnumerable<OrderDto> Orders { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Orders = await OrderService.GetOllOrders();
        }
    }
}
