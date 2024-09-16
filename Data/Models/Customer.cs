using System.ComponentModel.DataAnnotations;

namespace BlazorServerDemo.Data.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; } 
        public string Name {get; set;} 
        public int Age { get; set;} 
        public DateTime CreatedData { get; set;}
    }
}