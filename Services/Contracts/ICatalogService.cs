using OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models;

namespace OrderDeliverySystem.AdministrationPanel.Services.Contracts
{
    public interface ICatalogService
    {
        public Task<IEnumerable<ItemsByDaysDto>> GetOllItemsByDays();
    }
}
