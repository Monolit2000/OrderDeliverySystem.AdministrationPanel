using Microsoft.AspNetCore.Components;
using OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models;

namespace OrderDeliverySystem.AdministrationPanel.Components.Pages.Catalogs
{
    public class DisplayItemToTableBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ItemsByDaysDto> Items { get; set; }

    }
}
