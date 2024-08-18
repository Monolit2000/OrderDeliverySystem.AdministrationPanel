namespace OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models
{
    public class OptionalItemDto
    {
        public string? OptionalItemName { get; set; }
        public string? OptionalItemDescription { get; set; }
        public decimal OptionalItemPrice { get; set; } = default;
    }
}
