using OrderDeliverySystem.AdministrationPanel.Services.Contracts;
using OrderDeliverySystem.AdministrationPanel.Services.Order.Models;
using System.Net;
using System.Text.Json;

namespace OrderDeliverySystem.AdministrationPanel.Services.Order
{
    public class OrderService : IOrderService
    {
        public readonly HttpClient _httpClient;
        public readonly IConfiguration _configuration;

        public OrderService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration; 
        }

        public async Task<IEnumerable<OrderDto>> GetAllOrders()
        {
            try
            {
                var items = await _httpClient.GetFromJsonAsync<IEnumerable<OrderDto>>(_configuration["OrderDeliverySystemServiceUrl"] + "/api/Order/GetAllOrders");

                return items;
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                throw; 
            }
        }



        public async Task<IEnumerable<OrderDto>> GetAllOrdersByDay()
        {
            try
            {
                var items = await _httpClient.GetFromJsonAsync<IEnumerable<OrderDto>>(_configuration["OrderDeliverySystemServiceUrl"] + "/api/Order/GetAllOrders");

                return items;
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }
        }




        public async Task<Result<SetOrderStatusResult,string>> SetPaidOrderStatus(Guid orderId)
        {
            try
            {
                var data = new { OrderId = orderId };
                var response = await _httpClient.PostAsJsonAsync(_configuration["OrderDeliverySystemServiceUrl"] + "/api/Order/SetPaidOrderStatus", data);

                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new HttpRequestException("Order not found.");
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var errors = JsonSerializer.Deserialize<List<string>>(errorContent);
                    var errorMessage = string.Join("; ", errors);

                    return Result<SetOrderStatusResult, string>.Err($"{errorMessage}");
                }
                else if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"Server returned error: {response.StatusCode}. Details: {errorContent}");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<SetOrderStatusResult>(responseContent, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return Result<SetOrderStatusResult, string>.Ok(result); 
            }
           
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }
        }



        public async Task<Result<ChangeOrderStatusResult, string>> ChangeOrderStatus(Guid orderId, string status)
        {
            try
            {
                var data = new { OrderId = orderId, Status = status};
                var response = await _httpClient.PostAsJsonAsync(_configuration["OrderDeliverySystemServiceUrl"] + "/api/Order/ChangeOrderStatus", data);

                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new HttpRequestException("Order not found.");
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var errors = JsonSerializer.Deserialize<List<string>>(errorContent);
                    var errorMessage = string.Join("; ", errors);

                    return Result<ChangeOrderStatusResult, string>.Err($"{errorMessage}");
                }
                else if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"Server returned error: {response.StatusCode}. Details: {errorContent}");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ChangeOrderStatusResult>(responseContent, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return Result<ChangeOrderStatusResult, string>.Ok(result);
            }

            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }
        }




        public async Task<Result<List<OrderItemDtoByDay>, string>> GetAllOrderItemsByDayRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                var data = new { StartDate = startDate, EndDate = endDate };
                var response = await _httpClient.PostAsJsonAsync(_configuration["OrderDeliverySystemServiceUrl"] + "/api/Order/GetAllOrderItemsByDayRange", data);

                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    return Result<List<OrderItemDtoByDay>, string>.Err("Order not found.");
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var errors = JsonSerializer.Deserialize<List<string>>(errorContent);
                    var errorMessage = string.Join("; ", errors);

                    return Result<List<OrderItemDtoByDay>, string>.Err($"{errorMessage}");
                }
                else if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();

                    return Result<List<OrderItemDtoByDay>, string>.Err($"Server returned error: {response.StatusCode}. Details: {errorContent}");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<List<OrderItemDtoByDay>>(responseContent, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return Result<List<OrderItemDtoByDay>, string>.Ok(result);
            }

            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }
        }


    }
}

