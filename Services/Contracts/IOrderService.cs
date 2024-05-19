using OrderDeliverySystem.AdministrationPanel.Services.Order.Models;

namespace OrderDeliverySystem.AdministrationPanel.Services.Contracts
{
    public interface IOrderService
    {
        public Task<IEnumerable<OrderDto>> GetOllOrders();

        public Task<Result<SetOrderStatusResult,string>> SetPaidOrderStatus(Guid orderId);

        public Task<Result<ChangeOrderStatusResult, string>> ChangeOrderStatus(Guid orderId, string status);
    }
}
