using OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models;

namespace OrderDeliverySystem.AdministrationPanel.Services.Contracts
{
    public interface ICatalogService
    {
        public Task<IEnumerable<ItemsByDaysDto>> GetAllItemsByDays();

        public Task<List<CatalogItem>> GetAllCatalogItems();

        public Task<CatalogItemResponce> GetCatalogItemById(Guid catalogItemId);

        public Task AddCatalogItem(AddCatalogItemRequest catalogItem);

        public Task UpdateItemAsync(EditCatalogItemRequest catalogItem);

        public Task RemoveItemAsync(Guid Id);

        public Task<List<CatalogItemsByWeekDto>> GetAllCatalogItemsByWeek();

        public Task<string> UploadPhotoAsync(Stream stream, string contentType, string name, string fileName);

        public Task<string> UploadImageAsync(string fileName, Stream fileStream);

    }
}
