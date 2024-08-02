namespace OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models
{
    public class ItemsByDaysDto
    {
        public DateTime Day { get; set; }

        public List<CatalogItem> Items { get; set; } = [];
    }
}
