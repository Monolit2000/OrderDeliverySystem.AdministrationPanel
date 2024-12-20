﻿namespace OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models
{
    public class AddCatalogItemRequest
    {
        public string Name { get; set; }

        public DateTime TimeToExist { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PictureUrl { get; set; }


        public string? OptionalItemName { get; set; }
        public string? OptionalItemDescription { get; set; }
        public decimal OptionalItemPrice { get; set; } = default;
    }
}
