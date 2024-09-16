using System.ComponentModel.DataAnnotations;

namespace BlazorServerDemo.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string ItemDescription { get; set; }
        public int Quanity { get; set; }
        public Customer Customer { get; set; }
    }
}