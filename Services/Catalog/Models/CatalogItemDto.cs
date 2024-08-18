namespace OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models
{
    public class CatalogItemDto
    {
        public Guid CatalogItemId { get; set; }
        public string Name { get; set; }
        public DateTime TimeToItemExist { get; set; }
        public Guid ProductId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureFileName { get; set; } = string.Empty;
        public string PictureUri { get; set; } = string.Empty;

        public OptionalItemDto OptionalItemDto { get; set; }

    }
}
