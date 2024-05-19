using Microsoft.Extensions.Configuration;
using OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models;
using OrderDeliverySystem.AdministrationPanel.Services.Contracts;

namespace OrderDeliverySystem.AdministrationPanel.Services.Catalog
{
    public class CatalogService : ICatalogService
    {
        public readonly HttpClient _httpClient;
        public readonly IConfiguration _configuration;

        public CatalogService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<IEnumerable<ItemsByDaysDto>> GetOllItemsByDays()
        {
            try
            {
                var items = await _httpClient.GetFromJsonAsync<IEnumerable<ItemsByDaysDto>>(_configuration["OrderDeliverySystemServiceUrl"] + "/api/Catalog/CatalogItem/GetOllItemsByDays");

                return items;
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }
        }
    }
}
