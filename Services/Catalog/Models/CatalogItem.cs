namespace OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models
{
    public class CatalogItem
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public DateTime Deadline { get; set; }

        public string PictureUri { get; set; }
    }
}
