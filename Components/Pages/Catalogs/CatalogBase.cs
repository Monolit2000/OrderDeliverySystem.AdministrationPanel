using Microsoft.AspNetCore.Components;
using OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models;
using OrderDeliverySystem.AdministrationPanel.Services.Contracts;

namespace OrderDeliverySystem.AdministrationPanel.Components.Pages
{
    public class CatalogBase : ComponentBase
    {
        [Inject]
        public ICatalogService CatalogService { get; set; }

        public IEnumerable<ItemsByDaysDto> Items { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Items = await CatalogService.GetOllItemsByDays();
        }
    }
}
