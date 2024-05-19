using Microsoft.AspNetCore.Components;
using OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models;

namespace OrderDeliverySystem.AdministrationPanel.Components.Pages.Catalogs
{
    public class DisplayItemBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ItemsByDaysDto> Items { get; set; }
    }
}
