namespace OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models
{
    public class AddCatalogItemRequest
    {
        public string Name { get; set; }

        public DateTime TimeToExist { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PictureUrl { get; set; }

    }
}
