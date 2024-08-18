using OrderDeliverySystem.AdministrationPanel.Services.Order.Models;

namespace OrderDeliverySystem.AdministrationPanel.Services.Contracts
{
    public interface IOrderService
    {
        public Task<IEnumerable<OrderDto>> GetAllOrders();

        public Task<Result<SetOrderStatusResult,string>> SetPaidOrderStatus(Guid orderId);

        public Task<Result<ChangeOrderStatusResult, string>> ChangeOrderStatus(Guid orderId, string status);

        //public Task<Result<ChangeOrderItemStatusResult, string>> ChangeOrderItemStatus(Guid orderId, string status);

        public Task<Result<ChangeOrderItemStatusResult, string>> ChangeOrderItemStatus(Guid orderId, Guid orderItemId, string newStatus);

        public Task<Result<List<OrderItemDtoByDay>, string>> GetAllOrderItemsByDayRange(DateTime startDate, DateTime endDate);
    }
}
