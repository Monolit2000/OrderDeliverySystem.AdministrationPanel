namespace OrderDeliverySystem.AdministrationPanel.Services.Order.Models
{
    public class OrderTest
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string Customer { get; set; }
        public string Status { get; set; }
        public string DeliveryStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime Deadline { get; set; }
        public decimal Price { get; set; }
    }
}
