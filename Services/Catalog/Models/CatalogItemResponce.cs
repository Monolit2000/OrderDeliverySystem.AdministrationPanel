using System.Text.Json.Serialization;

namespace OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models
{
    public class CatalogItemResponce
    {
        [JsonPropertyName("itemId")]
        public Guid ItemId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("imageUri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("day")]
        public DateTime Day { get; set; }

        [JsonPropertyName("optionalItemName")]
        public string? OptionalItemName { get; set; }

        [JsonPropertyName("optionalItemDescription")]
        public string? OptionalItemDescription { get; set; }

        [JsonPropertyName("optionalItemPrice")]
        public decimal OptionalItemPrice { get; set; } = default;
    }
}
