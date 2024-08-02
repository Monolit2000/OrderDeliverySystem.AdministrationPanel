﻿namespace OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models
{
    public class EditCatalogItemRequest
    {
        public Guid CatalogItemId { get; set; }
        public string Name { get; set; }
        public DateTime TimeToItemExist { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUri { get; set; }
    }
}