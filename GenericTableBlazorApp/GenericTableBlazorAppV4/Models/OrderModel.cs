using System.ComponentModel.DataAnnotations.Schema;

namespace GenericTableBlazorAppV4.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public DateTime CreateOrderDate { get; set; }
        public DateTime CloseOrderDate { get; set;}
        public int FullPrice { get; set; }
        public bool IsCanceled { get; set; } = false;
        public CustomerModel CustomerModel { get; set; }
       
        public int CustomerModelId { get; set; }
        
    }
}
