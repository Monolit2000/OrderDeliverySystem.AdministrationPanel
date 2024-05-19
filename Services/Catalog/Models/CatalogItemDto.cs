namespace OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models
{
    public class CatalogItemDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUri { get; set; }

        public decimal Price { get; set; }

        public string PictureUri { get; set; }
    }
}
