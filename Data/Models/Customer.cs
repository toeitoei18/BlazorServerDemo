using System.ComponentModel.DataAnnotations;

namespace BlazorServerDemo.Data.Models
{
    public class Customer
    {
        [Key] //ใช้บอกFramework Entity ว่าคลาสนี้เป็นคีย์หลัก//
        public int Id { get; set; } 
        public string Name {get; set;} 
        public int Age { get; set;} 
        public DateTime CreatedData { get; set;} //จะแสดงเวลาที่สร้างในDb
        
        //ประกาศคลาสของลูกค้า
    }
}