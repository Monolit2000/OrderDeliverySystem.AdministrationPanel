using MudBlazor;
using OrderDeliverySystem.AdministrationPanel.Components.Pages.Orders;
using OrderDeliverySystem.AdministrationPanel.Services.Catalog.Models;
using OrderDeliverySystem.AdministrationPanel.Services.Contracts;
using OrderDeliverySystem.AdministrationPanel.Services.Order.Models;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static MudBlazor.CategoryTypes;

namespace OrderDeliverySystem.AdministrationPanel.Services.Catalog
{
    public class CatalogService : ICatalogService
    {
        public readonly HttpClient _httpClient;
        public readonly IConfiguration _configuration;

        private ISnackbar SnackBar { get; }

        public CatalogService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<IEnumerable<ItemsByDaysDto>> GetAllItemsByDays()
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

        public async Task<List<CatalogItem>> GetAllCatalogItems()
        {
            try
            {
                var items = await _httpClient.GetFromJsonAsync<List<CatalogItem>>(_configuration["OrderDeliverySystemServiceUrl"] + "/api/Catalog/CatalogItem/GetAllCatalogItem");

                return items;
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }
        }


        public async Task<List<CatalogItemsByWeekDto>> GetAllCatalogItemsByWeek()
        {
            try
            {
                var items = await _httpClient.GetFromJsonAsync<List<CatalogItemsByWeekDto>>(_configuration["OrderDeliverySystemServiceUrl"] + "/api/Catalog/CatalogItem/GetAllCatalogItemsByWeek");

                return items;
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }
        }



        public async Task<CatalogItemResponce> GetCatalogItemById(Guid itemId)
        {

            var request = new { ItemId = itemId };

            try
            {
                // Преобразуйте request в JSON строку
                var requestContent = new StringContent(
                    JsonSerializer.Serialize(request),
                    Encoding.UTF8,
                    "application/json"
                );

                // Отправьте POST запрос
                var response = await _httpClient.PostAsync(
                    _configuration["OrderDeliverySystemServiceUrl"] + "/api/Catalog/CatalogItem/GetItemById",
                    requestContent
                );

                // Проверьте, что ответ успешный
                response.EnsureSuccessStatusCode();

                if(response.IsSuccessStatusCode == false)
                {
                    this.SnackBar.Add("Error", Severity.Error);
                }
              
                //this.SnackBar.Add("GetCatalogItemById.", Severity.Success);

                // Прочитайте содержимое ответа
                var responseContent = await response.Content.ReadAsStringAsync();

                // Десериализуйте JSON в объект CatalogItem
                var item = JsonSerializer.Deserialize<CatalogItemResponce>(responseContent);

                return item;
            }
            catch (Exception ex)
            {
                // Запишите сообщение об ошибке в консоль
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }


        }

        public async Task AddCatalogItem(AddCatalogItemRequest catalogItem)
        {

            var request = catalogItem;

            try
            {
                // Преобразуйте request в JSON строку
                var requestContent = new StringContent(
                    JsonSerializer.Serialize(request),
                    Encoding.UTF8,
                    "application/json"
                );

                // Отправьте POST запрос
                var response = await _httpClient.PostAsync(
                    _configuration["OrderDeliverySystemServiceUrl"] + "/api/Catalog/CatalogItem/AddCatalogItem",
                    requestContent
                );

                // Проверьте, что ответ успешный
                //response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode == false)
                {
                    Console.WriteLine("ERERERERADDDDDD");
                    return;
                    //this.SnackBar.Add("Error", Severity.Error);
                }

                //this.SnackBar.Add("GetCatalogItemById.", Severity.Success);

                // Прочитайте содержимое ответа
                var responseContent = await response.Content.ReadAsStringAsync();

                // Десериализуйте JSON в объект CatalogItem
                //return JsonSerializer.Deserialize<CatalogItem>(responseContent);
            }
            catch (Exception ex)
            {
                // Запишите сообщение об ошибке в консоль
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }

        }

        public async Task UpdateItemAsync(EditCatalogItemRequest catalogItem)
        {
            var request = catalogItem;

            try
            {
                // Преобразуйте request в JSON строку
                var requestContent = new StringContent(
                    JsonSerializer.Serialize(request),
                    Encoding.UTF8,
                    "application/json"
                );

                // Отправьте POST запрос
                var response = await _httpClient.PostAsync(
                    _configuration["OrderDeliverySystemServiceUrl"] + "/api/Catalog/CatalogItem/EditCatalogItem",
                    requestContent
                );

                // Проверьте, что ответ успешный
                //response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode == false)
                {
                    Console.WriteLine("ERERERERADDDDDD");
                    return;
                    //this.SnackBar.Add("Error", Severity.Error);
                }

                //this.SnackBar.Add("GetCatalogItemById.", Severity.Success);

                // Прочитайте содержимое ответа
                var responseContent = await response.Content.ReadAsStringAsync();

                // Десериализуйте JSON в объект CatalogItem
                //return JsonSerializer.Deserialize<CatalogItem>(responseContent);
            }
            catch (Exception ex)
            {
                // Запишите сообщение об ошибке в консоль
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }
        }

        public async Task RemoveItemAsync(Guid Id)
        {
            var request = new { CatalogItemId = Id };

            try
            {
                // Преобразуйте request в JSON строку
                var requestContent = new StringContent(
                    JsonSerializer.Serialize(request),
                    Encoding.UTF8,
                    "application/json"
                );

                // Отправьте POST запрос
                var response = await _httpClient.PostAsync(
                    _configuration["OrderDeliverySystemServiceUrl"] + "/api/Catalog/CatalogItem/DeleteCatalogItem",
                    requestContent
                );

                // Проверьте, что ответ успешный
                //response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode == false)
                {
                    Console.WriteLine("ERERERERADDDDDD");
                    return;
                    //this.SnackBar.Add("Error", Severity.Error);
                }

                //this.SnackBar.Add("GetCatalogItemById.", Severity.Success);

                // Прочитайте содержимое ответа
                var responseContent = await response.Content.ReadAsStringAsync();

                // Десериализуйте JSON в объект CatalogItem
                //return JsonSerializer.Deserialize<CatalogItem>(responseContent);
            }
            catch (Exception ex)
            {
                // Запишите сообщение об ошибке в консоль
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }
        }
    }
}
