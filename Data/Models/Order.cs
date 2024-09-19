using System.ComponentModel.DataAnnotations;

namespace BlazorServerDemo.Data.Models
{
    public class Order
    {
        [Key]  //ใช้บอกFramework Entity ว่าคลาสนี้เป็นคีย์หลัก//
        public int Id { get; set; }
        public string ItemDescription { get; set; }
        public int Quanity { get; set; }
        public Customer Customer { get; set; }  //จะแสดงเวลาที่สร้างในDb
    
        //ประกาศคลาสของสินค้า
    }
}