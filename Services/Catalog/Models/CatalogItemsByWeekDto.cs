﻿namespace OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models
{
    public class CatalogItemsByWeekDto
    {
        public DateTime WeekStart { get; set; }
        public DateTime WeekEnd { get; set; }
        public List<CatalogItemDto> CatalogItems { get; set; } = new();
    }
}
