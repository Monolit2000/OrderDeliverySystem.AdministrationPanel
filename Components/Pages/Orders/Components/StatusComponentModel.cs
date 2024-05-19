using Microsoft.AspNetCore.Components;

namespace OrderDeliverySystem.AdministrationPanel.Components.Pages.Orders.Components
{
    public class StatusComponentModel : ComponentBase
    {
        [Parameter]
        public Status Status { get; set; }

        public string CssStatus 
        {
            get 
            {
                return Status.ToString().ToLower();
            } 
        }
    }
}
